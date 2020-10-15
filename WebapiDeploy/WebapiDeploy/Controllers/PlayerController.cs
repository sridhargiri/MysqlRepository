using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebapiDeploy.Model;
using WebapiDeploy.Repository;

namespace WebapiDeploy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _repo;

        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger, IPlayerRepository repo)
        {
            _logger = logger; _repo = repo;
        }
        /// <summary>
        /// List all players
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PlayerCollection Get()
        {
            return _repo.GetPlayers();
        }
        /// <summary>
        /// List all players
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public PlayerCollection GetById(int id)
        {
            return _repo.GetPlayerById(id);
        }
        /// <summary>
        /// Add Players
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Player player)
        {
            return Ok(_repo.Add(player));
        }
        /// <summary>
        /// Update player score
        /// </summary>
        /// <param name="player"></param>
        [HttpPatch("Update")]
        public void Update([FromBody] Player player)
        {
            _repo.Update(player);
        }
    }
}
