using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomisSamochodowy.Models
{
    public class OpiniaRepository : IOpiniaRepository
    {
        private readonly AppDbContext _appDbContext;
        public OpiniaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void DodjOpinie(Opinia opinia)
        {
            _appDbContext.Opinie.Add(opinia);
            _appDbContext.SaveChanges();
        }
    }
}
