using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Автопарк
    /// </summary>
    public class AvtoPark : BaseEntity
    {
        public string Address { get; set; }

        public string ParkSize { get; set; }

        public int SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }
    }
}
