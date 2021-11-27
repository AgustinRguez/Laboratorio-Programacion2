using ExamplePruebaApi.Application;
using ExamplePruebaApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        IApplication<FootballTeam> football;
        public FootballTeamController(IApplication<FootballTeam> football)
        {
            this.football = football;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(football.GetAll()); 
        }
        [HttpPost]
        public IActionResult Save(FootballTeamDTO dto)
        {
            var f = new FootballTeam()
            {
                name = dto.Name,
                score = dto.Score
            };
            return Ok(football.Save(f)); //hasta el video 2 hice
        }

    }
}
