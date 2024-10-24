using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace rest_api.Controllers {
    [ApiController]
    [Route("admin")]
    public class AdminController(DBContext context) : ControllerBase {
        private readonly DBContext db = context;

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers() {
            var users = await db.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("puzzles")]
        public async Task<IActionResult> GetPuzzles() {
            var puzzles = await db.Puzzles.ToListAsync();

            return Ok(puzzles);
        }
    }
}
