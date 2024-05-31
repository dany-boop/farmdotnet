using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models.Entity;

namespace MVC.Controllers
{
    public class FarmController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FarmController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Farms
        public async Task<IActionResult> Index()
        {
            var farms = _context.Farm.Include(f => f.Type).Include(f => f.Investor);
            return View(await farms.ToListAsync());
        }

        // GET: Farms/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farm = await _context.Farm
                .Include(f => f.Type)
                .Include(f => f.Investor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        // GET: Farms/Create
        public IActionResult Add()
        {
            ViewData["Type_Id"] = new SelectList(_context.CattleType, "Id", "Name");
            ViewData["Investor_Id"] = new SelectList(_context.User, "Id", "Name");
            return View();
        }

        // POST: Farms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Id,Code,Type_Id,Investor_Id,Buy_Price,Sell_Price,Treament_Price,status,Male_Breeder,Male_Id,Female_Breeder,Female_Id")] Farm farm)
        {
            if (ModelState.IsValid)
            {
                farm.Id = Guid.NewGuid();
                farm.Male_Breeder = Guid.NewGuid();
                farm.Female_Breeder = Guid.NewGuid();
                Console.WriteLine("ga1sg1as");
                _context.Add(farm);
                await _context.SaveChangesAsync();
                Console.WriteLine("g3asg4as");
                return RedirectToAction(nameof(Index));
            }           
            Console.WriteLine("ga2sg2as");
            ViewData["Type_Id"] = new SelectList(_context.CattleType, "Id", "Name", farm.Type_Id);
            ViewData["Investor_Id"] = new SelectList(_context.User, "Id", "Name", farm.Investor_Id);
            return View(farm);
        }

        // GET: Farms/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farm = await _context.Farm.FindAsync(id);
            if (farm == null)
            {
                return NotFound();
            }
            ViewData["Type_Id"] = new SelectList(_context.CattleType, "Id", "Name", farm.Type_Id);
            ViewData["Investor_Id"] = new SelectList(_context.User, "Id", "Name", farm.Investor_Id);
            return View(farm);
        }

        // POST: Farms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Code,Type_Id,Investor_Id,Buy_Price,Sell_Price,Treament_Price,status,Male_Breeder,Male_Id,Female_Breeder,Female_Id")] Farm farm)
        {
            if (id != farm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(farm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmExists(farm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Type_Id"] = new SelectList(_context.CattleType, "Id", "Name", farm.Type_Id);
            ViewData["Investor_Id"] = new SelectList(_context.User, "Id", "Name", farm.Investor_Id);
            return View(farm);
        }

        // GET: Farms/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farm = await _context.Farm
                .Include(f => f.Type)
                .Include(f => f.Investor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (farm == null)
            {
                return NotFound();
            }

            return View(farm);
        }

        // POST: Farms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var farm = await _context.Farm.FindAsync(id);
            _context.Farm.Remove(farm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmExists(Guid id)
        {
            return _context.Farm.Any(e => e.Id == id);
        }
    }
}
