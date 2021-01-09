using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Событие
    /// </summary>
    public class Events : BaseEntity
    {
        public string NameEvent { get; set; }

        public DateTime DataEvent { get; set; }

        public int SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }
    }
}
