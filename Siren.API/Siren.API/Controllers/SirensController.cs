using Microsoft.AspNetCore.Mvc;
using Siren.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Siren.API.Controllers
{
    public class SirensController : Controller
    {
        [HttpGet("api/sirens")]
        public IActionResult GetSirens()
        {

            return Ok(SirensDataStore.Current.Sirens);


        }
        [HttpGet("API/Sirens/{id}")]
        public IActionResult GetSiren(String ID)
        {
            var sirenToReturn = SirensDataStore.Current.Sirens.FirstOrDefault(c => c.ID == ID);
            if (sirenToReturn == null)
            {
                return NotFound();
            }
            {
                return Ok(sirenToReturn);
            }
        }
        [HttpPost("API/Sirens")]
        public IActionResult CreateSiren([FromBody] SirenDtoForCreation siren)
        {
            var finalSiren = new SirenDto()
            {
            Description = siren.Description,
            Severity = siren.Severity,
            Start = siren.Start,
            End = siren.End,
            ID = Guid.NewGuid().ToString()
            };
            String route = "API/Sirens/" + 4;
            return CreatedAtRoute(route, finalSiren);
            
    }
}
}
