using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Учителя
    /// </summary>
    public class Teacher : BaseEntity
    {
        public string FIO { get; set; }

        public int? PositionId { get; set; }

        public int? EmployeeId { get; set; }

        public int? ExperienceId { get; set; }


        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("ExperienceId")]
        public virtual Experience Experience { get; set; }
    }
}
