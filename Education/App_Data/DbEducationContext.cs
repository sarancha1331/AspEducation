using Education.Entities;
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

        public DbSet<Avto> Avto { get; set; }
        public DbSet<AvtoPark> AvtoPark  { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Events> Event { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Federation> Federation { get; set; }
        public DbSet<Olimpic> Olimpic { get; set; }
        public DbSet<OlimpicAndStudent> OlimpicAndStudent { get; set; }
        public DbSet<OtherPersonal> OtherPersonal { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Salary> Salarie { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Sport> Sport { get; set; }
        public DbSet<Sportsman> Sportsmen { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
    }
}
