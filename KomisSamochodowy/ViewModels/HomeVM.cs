using KomisSamochodowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomisSamochodowy.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
