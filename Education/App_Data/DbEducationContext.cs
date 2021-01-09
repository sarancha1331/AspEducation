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

        public DbSet<Avto> Avtos { get; set; }
        public DbSet<AvtoPark> AvtoParks  { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Federation> Federations { get; set; }
        public DbSet<Olimpic> Olimpics { get; set; }
        public DbSet<OlimpicAndStudent> OlimpicAndStudents { get; set; }
        public DbSet<OtherPersonal> OtherPersonals { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Sportsman> Sportsmen { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
