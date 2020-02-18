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
    public class HistoryOrderController : Controller
    {

        private readonly APITrackingContext _context;
        public HistoryOrderController(APITrackingContext context)
        {
            _context = context;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<ShipmentHistory>>> GetHis()
        {
            var getOrder = await _context.ShipmentHistory.ToListAsync();

            return Ok(getOrder);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{ShipmentNumber}")]
        public async Task<ActionResult<IAsyncEnumerable<ShipmentHistory>>> GetHisItens(String ShipmentNumber)
        {

            string querySql = "SELECT * FROM ShipmentHistory "
            + "where HIS_ShipmentNumber = '{0}'";

            var orderQuery = String.Format(querySql, ShipmentNumber);

            var getOrderQuery = await _context.ShipmentHistory
                .FromSqlRaw(orderQuery)
                .ToListAsync();

            if (getOrderQuery == null)
            {
                return NotFound();
            }

            return Ok(getOrderQuery);

        }
    }
}