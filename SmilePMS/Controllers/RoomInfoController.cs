using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmilePMS.Entities;
using SmilePMS.Models;

namespace SmilePMS.Controllers
{
    [Route("api/getListRoom")]
    [ApiController]
    public class RoomInfoController : ControllerBase
    {
        private readonly SMILEPMSDBQueryContext _context;

        public RoomInfoController(SMILEPMSDBQueryContext context)
        {
            _context = context;
        }

        // GET: api/RoomInfo
        [HttpGet]
        public async Task<ActionResult<GenericResponse<Dictionary<string, IEnumerable<RoomResponse>>>>> GetRoomInfos()
        {
            try
            {
                var roomInfos = await _context.RoomInfos.ToListAsync();

                var roomByFloors = roomInfos.GroupBy(r => r.FloorNum);

                var resultDictionary = new Dictionary<string, IEnumerable<RoomResponse>>();
                foreach (IGrouping<int, RoomInfo> roomsbyFloor in roomByFloors)
                {
                    var roomsResponse = new List<RoomResponse>();
                    foreach (var roomInfo in roomsbyFloor)
                    {
                        var room = new RoomResponse()
                        {
                            RoomId = roomInfo.RoomCode,
                            RoomType = roomInfo.RoomTypeCode,
                            Description = roomInfo.Description,
                            isAvailability = roomInfo.IsAvailability,
                            Inspected = roomInfo.Inspected,
                        };
                        roomsResponse.Add(room);
                    }
                    resultDictionary.Add(roomsbyFloor.Key.ToString(), roomsResponse);
                }

                var response = new GenericResponse<Dictionary<string, IEnumerable<RoomResponse>>>()
                {
                    Data = resultDictionary,
                    Success = true,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new GenericResponse<string>()
                {
                    Success= false,
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }

        private bool RoomInfoExists(int id)
        {
            return _context.RoomInfos.Any(e => e.RoomCode == id);
        }
    }
}
