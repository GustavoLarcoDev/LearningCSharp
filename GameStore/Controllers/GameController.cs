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
        public IActionResult Create_Game(Game new_game)
        {
            _context.Games.Add(new_game);
            _context.SaveChanges();
            var games = from game in _context.Games
                        select game;


            return View("Index", games.ToList());
        }


        [HttpDelete("{id}/Delete")]
        public IActionResult Delete_Game(int id)
        {
            Game game = _context.Games.Find(id);
            _context.Games.Remove(game);
            _context.SaveChanges();
            var games = from g in _context.Games
                        select g;
            return View("_Table", games.ToList());
            
        }
    }
}
