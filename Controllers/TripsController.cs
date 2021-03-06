using System.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrIpsNew.Data.Models;
using TrIpsNew.Services;

namespace TrIpsNew.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;
        public TripsController(ITripService service)
        {
            this._service = service;
        }
        [HttpGet("[action]")]
        public IActionResult GetTrips(){
            try{
                //throw new Exception();
                var allTrips = _service.GetAllTrips();
                return Ok(allTrips);
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("SingleTrip/{id}")]
        public IActionResult GetTripById(int id){
            var Trip = _service.GetTripByID(id);
            return Ok(Trip);
        }
        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody] Trip trip){
            if(trip != null){
                _service.AddTrip(trip);
            }
            return Ok();
        }
        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody] Trip trip){
            _service.UpdateTrip(id, trip);
            return Ok(trip);
        }
        [HttpDelete("DeleteTrip/{id}")]
        public IActionResult DeleteTrip(int Id){
            _service.DeleteTrip(Id);
            return Ok();
        }
    }
}