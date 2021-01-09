using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.App_Data
{
    public class DbEducationContext : DbContext
    {

        public DbEducationContext(DbContextOptions<DbEducationContext> options) : base(options) { }

    }
}
