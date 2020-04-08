using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomisSamochodowy.Models;
using KomisSamochodowy.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KomisSamochodowy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);
            var homeVM = new HomeVM()
            {
                Tytul = "Przegląd Samochodów",
                Samochody = samochody.ToList()
            };

            return View(homeVM);
        }
    }
}
