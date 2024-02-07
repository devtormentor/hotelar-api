using System.Net.Http.Headers;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.DataBase;
using hotelar.Infrastructure.RepositoryPattern.Contracts;
using Microsoft.EntityFrameworkCore;

namespace hotelar.Infrastructure.RepositoryPattern.Implementations
{
    public class RoomImplementations(DataContext context) : IRoomContracts
    {
        private readonly DataContext context = context;

        public async Task<Room> GetRoomById(int id)
        {
            var room = await context.Tb_Room.FirstOrDefaultAsync( r => r.Id == id);
            return room;
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            var rooms =await  context.Tb_Room.ToListAsync();

            return rooms;
        }

        public async Task CreateRoom(RoomDTO room)
        {
            // criar quarto
            var newRoom = new Room{
               RoomNumber= room.RoomNumber,
               RoomType=room.RoomType,
               CreatedAt = DateTime.Now
            };
            await context.AddAsync(newRoom);
            await context.SaveChangesAsync();
            //fim de codigo criar
        }

        public async Task DeleteRoom(int id)
        {
            var roomtoDelete = this.GetRoomById(id);

            context.Remove(roomtoDelete);
            await context.SaveChangesAsync();
        }

        public async Task UpdateRoom(RoomDTO room, int id)
        {
            var roomToUpdate = await this.GetRoomById(id);

            roomToUpdate.RoomNumber = room.RoomNumber;
            roomToUpdate.RoomType = room.RoomType;
            roomToUpdate.UpdatedAt = DateTime.Now;

            context.UpdateRange(roomToUpdate);
            await context.SaveChangesAsync();
        }
        // exibir todos os quartos
    }
}