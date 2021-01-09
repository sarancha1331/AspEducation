using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Студенты
    /// </summary>
    public class Student : BaseEntity
    {
        public string FIO { get; set; }

        public string StudentGroup { get; set; }

        public DateTime DataBorn { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

    }
}
