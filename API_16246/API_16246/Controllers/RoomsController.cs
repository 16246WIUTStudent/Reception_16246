
//Student ID: 00016246

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_16246.Models;
using API_16246.Repositories;

namespace API_16246.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        /// <summary>
        /// Gets all the rooms.
        /// </summary>
        /// <returns>List of rooms</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            var rooms = await _roomRepository.GetAllAsync();
            return Ok(rooms);
        }

        /*
        /// <summary>
        /// Gets a specific room by ID.
        /// </summary>
        /// <param name="id">The ID of the room</param>
        /// <returns>The room object</returns>*/
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _roomRepository.GetByIdAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        /// <summary>
        /// Updates an existing room.
        /// </summary>
        /// <param name="id">The ID of the room</param>
        /// <param name="room">The updated room object</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.RoomId)
            {
                return BadRequest();
            }

            var result = await _roomRepository.UpdateAsync(room);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        /// <summary>
        /// Creates a new room.
        /// </summary>
        /// <param name="room">The room object to create</param>
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            var createdRoom = await _roomRepository.AddAsync(room);
            return CreatedAtAction(nameof(GetRoom), new { id = createdRoom.RoomId }, createdRoom);
        }

        /// <summary>
        /// Deletes a room by ID.
        /// </summary>
        /// <param name="id">The ID of the room to delete</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var result = await _roomRepository.DeleteAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
