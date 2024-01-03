using System.Text.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Http.Features;


namespace hotelar.api.Root
{
    public static class ServiceCollectionExt
    {
        public static WebApplicationBuilder AddControllersConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()

            //politica de controlo de loops e serialização
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling
                    = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
                    = new DefaultContractResolver())
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.AllowTrailingCommas = true;
                    options.JsonSerializerOptions.DefaultBufferSize = 1024;
                    options.JsonSerializerOptions.IgnoreReadOnlyFields = true;
                    options.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                    options.JsonSerializerOptions.ReadCommentHandling = new JsonCommentHandling();
                    options.JsonSerializerOptions.UnknownTypeHandling = new JsonUnknownTypeHandling();
                });
            return builder;
        }

        public static WebApplicationBuilder AddDataProtectionConfig(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddDataProtection()
                .UseCryptographicAlgorithms(new AuthenticatedEncryptorConfiguration
                {
                    EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
                    ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
                });

            return builder;
        }

        public static WebApplicationBuilder AddConfigurationConfig(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<FormOptions>(o =>
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });
            return builder;
        }

        public static WebApplicationBuilder AddPersistenceConfig(this WebApplicationBuilder builder)
        {

            //varieable for introduce connection strings
            //builder.Services.AddDbContext<SiadesDbContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
            //    .EnableSensitiveDataLogging()
            //    .EnableThreadSafetyChecks()
            //);

            //builder.Services.AddTransient<IBloodRepository, BloodRepository>().AddLogging();
    
            return builder;
        }
    }
}