using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Firm
{
    class FirmContext: DbContext
    {       
        public FirmContext() : base("fDb")
        {
            Database.SetInitializer<FirmContext>(new DropCreateDatabaseAlways<FirmContext>()); // Make sure we dont save any data when the application is not running
        }

        public DbSet<Worker> DbWorker { get; set; }
        public DbSet<Department> DbDepartment { get; set; }
    }
}