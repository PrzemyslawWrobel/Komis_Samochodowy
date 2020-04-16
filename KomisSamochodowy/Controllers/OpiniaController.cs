using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomisSamochodowy.Models;
using Microsoft.AspNetCore.Mvc;

namespace KomisSamochodowy.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;
        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            _opiniaRepository.DodjOpinie(opinia);

            return RedirectToAction("OpiniaWyslana");
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}