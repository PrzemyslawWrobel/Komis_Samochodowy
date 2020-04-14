﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomisSamochodowy.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodOId(int samochodId);
    }
}
