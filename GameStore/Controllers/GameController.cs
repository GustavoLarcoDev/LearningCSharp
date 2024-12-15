using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    [Route("Game")]
    public class GameController : Controller
    {
        private readonly GameStoreContext _context;
        public GameController(GameStoreContext context) { 
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var games = from game in _context.Games
                        select game;


            return View(games.ToList());

            //return View();
        }
        [HttpPost("/Create")]
        public IActionResult Create_Game(Game model)
        {
            _context.Games.Add(model);
            _context.SaveChanges();
            var games = from game in _context.Games
                        select game;


            return View("Index", games);
        }
    }
}
