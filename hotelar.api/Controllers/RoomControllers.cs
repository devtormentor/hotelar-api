using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace hotelar.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController(IRoomContractApp contractApp) : ControllerBase
    {
        private readonly IRoomContractApp contractApp = contractApp;

        [HttpGet]
        public async Task<IActionResult> Get ()
        {
            var rooms = await contractApp.GetRooms();
            return Ok(rooms);
        }
        [HttpGet(nameof(GetRoomId))]
        public async Task<IActionResult> GetRoomId (int id)
        {
            var rooms = await contractApp.GetRoom(id);
            return Ok(rooms);
        }
        [HttpPost]
        public async Task<IActionResult> Insert (RoomDTO Room)
        {
            await contractApp.AddRoom(Room);
            return Ok("Room Added successfully");
        }
        [HttpPut]
        public async Task<IActionResult> Update (RoomDTO room, int id)
        {
            await contractApp.UpdateRoom(room, id);
            return NoContent();
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete (int id)
        {
            await contractApp.DeleteRoom(id);
            return NoContent();
        }
    }
}