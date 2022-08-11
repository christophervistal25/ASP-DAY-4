using API.DatabaseContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        public readonly ApplicationDbContext _context;

        public MotorcycleController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet(template: nameof(GetMotorcycles), Name = nameof(GetMotorcycles))]
        public IActionResult GetMotorcycles()
        {
            return Ok(this._context.Motorcycle.ToList());
        }

        [HttpGet(template:nameof(GetMotorcycleByID), Name = nameof(GetMotorcycleByID))]
        public IActionResult GetMotorcycleByID(long id)
        {
            // For relation
            var result = this._context.Motorcycle.Include(m => m.MotorcycleOwner).Where(x => x.Id == id).FirstOrDefault();

            return Ok(result);
        }
    }
}
