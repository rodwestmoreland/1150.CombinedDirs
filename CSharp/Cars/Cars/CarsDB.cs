using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Cars
{
    class CarsDB : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
