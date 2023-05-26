using Microsoft.AspNetCore.Mvc;
using Practice.Entities;
using Practice.Models;
using System.Diagnostics;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly PracticeContext _context;
        public HomeController(PracticeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Exam> listExam = _context.Exams.ToList<Exam>();
            List<Room> listRoom = _context.Rooms.ToList<Room>();
            List<Faculty> listFacuty = _context.Facultys.ToList<Faculty>();
            ViewBag.exams = listExam;
            ViewBag.rooms = listRoom;
            ViewBag.facultys = listFacuty;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}