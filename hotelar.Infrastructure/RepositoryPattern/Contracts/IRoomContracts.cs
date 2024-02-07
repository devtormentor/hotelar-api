using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;

namespace hotelar.Infrastructure.RepositoryPattern.Contracts
{
    public interface IRoomContracts
    {
        Task<IEnumerable<Room>> GetRooms();
        Task<Room> GetRoomById(int id);
        Task CreateRoom(RoomDTO Room);
        Task UpdateRoom(RoomDTO Room, int id);
        Task DeleteRoom(int id);
    }
}