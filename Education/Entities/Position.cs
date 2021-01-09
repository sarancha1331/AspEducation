using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Position : BaseEntity
    {
        public string PositionName { get; set; }

        public int SalaryId { get; set; }

        [ForeignKey("SalaryId")]
        public Salary Salary { get; set; }

    }


}
