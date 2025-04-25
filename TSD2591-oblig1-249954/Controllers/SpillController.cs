using Microsoft.AspNetCore.Mvc;
using TSD2591_oblig1_249954.Data;   
using TSD2591_oblig1_249954.Models;  
using System.Linq;

namespace TSD2591_oblig1_249954.Controllers
{
    public class SpillController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor for å hente inn DbContext
        public SpillController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Viser spillet
        public IActionResult Spill2Like()
        {
            return View();
        }

        // Tar imot POST fra fetch når spillet er ferdig og oppdaterer antall spill for bruker
        [HttpPost]
        public IActionResult OppdaterSpillCount([FromBody] BrukerData data)
        {
            var bruker = _context.Brukere.FirstOrDefault(b => b.Navn == data.Navn);
            if (bruker != null)
            {
                bruker.AntallSpill += 1;
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }

    // Klasse for å ta imot JSON-data fra fetch (navn på bruker)
    public class BrukerData
    {
        public string Navn { get; set; }
    }
}
