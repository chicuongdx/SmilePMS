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
    [Route("api/getListRoomType")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly SMILEPMSDBQueryContext _context;

        public RoomTypeController(SMILEPMSDBQueryContext context)
        {
            _context = context;
        }

        // GET: api/RoomType
        [HttpGet]
        public async Task<ActionResult<GenericResponse<IEnumerable<RoomTypeResponse>>>> GetRoomTypes()
        {
            var response = new GenericResponse<IEnumerable<RoomTypeResponse>>()
            {
                Data = await _context.RoomTypes.Select(rt => new RoomTypeResponse
                {
                    RoomTypeCode = rt.RoomTypeCode,
                    Description = rt.Description
                }).ToListAsync(),

                Success = true
            };

            return Ok(response);
        }

        private bool RoomTypeExists(string id)
        {
            return _context.RoomTypes.Any(e => e.RoomTypeCode == id);
        }
    }
}
