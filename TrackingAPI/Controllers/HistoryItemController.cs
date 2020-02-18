using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using TrackingAPI.Models;

namespace TrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HistoryItemController : Controller
    {

        private readonly APITrackingContext _context;
        public HistoryItemController(APITrackingContext context)
        {
            _context = context;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{ShipmentGuid}")]
        public async Task<ActionResult<IAsyncEnumerable<ShipmentHistoryItemJs>>> GetHisItens(string ShipmentGuid)
        {
            //var getHistoryQuery = await _context.ShipmentHistoryItem.FindAsync(ShipmentGuid); 

            string querySql = "SELECT * FROM v_details2('{0}')";

            var historyQuery = string.Format(querySql, ShipmentGuid);

            var getHistoryQuery = await _context.ShipmentHistoryItemJs
                .FromSqlRaw(historyQuery)
                .ToListAsync();

            if (getHistoryQuery == null)
            {
                return NotFound();
            }

            return Ok(getHistoryQuery);

        }

    }
}