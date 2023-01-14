using Microsoft.AspNetCore.Mvc;
using Movie.Data.Data;
using Movie.Model.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Controllers
{
    public class StudioController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudioController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList = _db.Studios.ToList();
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Studio obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id) 
        {
            if (id == null)
            {

                return RedirectToAction("Index");
            }
            var ob = await _db.Studios.FindAsync(id);
            return View(ob);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Studio ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ob);
        }
        public async Task<IActionResult> Delete(int? id) 
        {
            if (id == null)
            {

                return RedirectToAction("Index");
            }
            var obj = await _db.Studios.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Studios.FindAsync(id);
            _db.Studios.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
