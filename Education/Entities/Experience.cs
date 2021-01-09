using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        public int ExperienceYear { get; set; }

        public int SalaryId { get; set; }

        [ForeignKey("SalaryId")]
        public Salary Salary { get; set; }
    }
}
