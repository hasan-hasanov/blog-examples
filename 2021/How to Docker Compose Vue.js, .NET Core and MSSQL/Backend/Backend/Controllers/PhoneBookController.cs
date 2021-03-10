using Backend.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/phone-book")]
    public class PhoneBookController : Controller
    {
        private readonly PhoneBookContext _context;

        public PhoneBookController(PhoneBookContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var phoneBookEntries = await _context.PhoneBookEntries.ToListAsync();
            IList<PhoneBookEntryModel> response = new List<PhoneBookEntryModel>();

            if (phoneBookEntries != null && phoneBookEntries.Any())
            {
                response = phoneBookEntries.Select(p => new PhoneBookEntryModel(p)).ToList();
            }

            return this.Ok(response);
        }
    }
}
