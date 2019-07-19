using OSCBOL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OSCDAL
{
    public class BaseRepositoryDb
    {
        protected OSCDbContext oscDbContext;
        public BaseRepositoryDb() {
            oscDbContext = new OSCDbContext();
        }

        public void Save() {
            oscDbContext.SaveChanges();
        }
    }
}
