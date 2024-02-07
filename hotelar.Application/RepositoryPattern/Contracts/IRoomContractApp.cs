using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;

namespace hotelar.Application.RepositoryPattern.Contracts
{
    public interface IRoomContractApp
    {
        Task<IEnumerable<Room>> GetRooms();
        Task<Room> GetRoom(int id);
        Task AddRoom(RoomDTO Room);
        Task UpdateRoom(RoomDTO room, int id);
        Task DeleteRoom(int id);
    }
}