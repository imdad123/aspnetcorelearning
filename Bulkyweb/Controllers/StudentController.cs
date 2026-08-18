using Bulkyweb.Data;
using Bulkyweb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bulkyweb.Controllers
{
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;


        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            HttpContext.Session.SetString("name", "imdadsession");
            var student = _context.students.ToList();
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await _context.students.AddAsync(std);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var stdData = _context.students.Find(id);
            return View(stdData);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Student std)
        {

            if (ModelState.IsValid)
            {
                _context.students.Update(std);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }
    }
}
