using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.RepositoryPattern.Contracts;

namespace hotelar.Application.RepositoryPattern.Implementations
{
    public class RoomImplementationApp(IRoomContracts roomContracts) : IRoomContractApp
    {
        private readonly IRoomContracts roomContracts = roomContracts;

        public async Task AddRoom(RoomDTO room)
        {
            try
            {
                await roomContracts.CreateRoom(room);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteRoom(int id)
        {
            await this.roomContracts.DeleteRoom(id);
        }

        public async Task<Room> GetRoom(int id)
        {
            var room = await roomContracts.GetRoomById(id);
            return room;
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            var rooms = await roomContracts.GetRooms();
            return rooms;
        }

        public async Task UpdateRoom(RoomDTO room, int id)
        {
            await this.roomContracts.UpdateRoom(room, id);
        }
    }
}