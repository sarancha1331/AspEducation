using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : BaseEntity
    {
        public DateTime DateOfEmployee { get; set;}

        public string Specialization { get; set; }
         
        public int SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }
    }
}
