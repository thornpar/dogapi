using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DogAPI.Controllers
{
    /// <summary>
    /// Responsible for dogs
    /// </summary>
    [Route("api")]
    public class DogController : ControllerBase
    {
        private readonly DogDatabase _dogDatabase;

        public DogController(DogDatabase dogDatabase)
        {
            _dogDatabase = dogDatabase;
        }
        
        /// <summary>
        /// Gets some dogs
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dogs")]
        public ActionResult<IEnumerable<object>> Get()
        {
            return Ok(_dogDatabase.Dogs.Select(e =>
                new
                {
                    Name = e.Name,
                    Race = e.Race,
                    //BestSkill = e.BestSkill
                }));
        }
    }
}