using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FIO { get; set; }

        public string StudentGroup { get; set; }

        public DateTime DataBorn { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

    }
}
