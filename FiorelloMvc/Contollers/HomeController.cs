using Core.Entities;
using DataAccess.Contexts;
using FiorelloMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloMvc.Contollers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                SlideBgs = _context.SlideBgs,
                SlideDescs = _context.SlideDescs

            };

            return View(homeVM);
        }
    }
}
