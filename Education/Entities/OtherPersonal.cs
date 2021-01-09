using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class OtherPersonal
    {
        [Key]
        public int Id { get; set; }

        public string FIO { get; set; }

        public int PositionId { get; set; }

        public int EmployeeId { get; set; }

        public int ExperienceId { get; set; }


        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("ExperienceId")]
        public Experience Experience { get; set; }
    }
}
