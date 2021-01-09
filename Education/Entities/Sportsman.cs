using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Sportsman
    {
        [Key]
        public int Id { get; set; }

        public int FederationId { get; set; }

        public int SportId { get; set; }

        public string Status { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("FederationId")]
        public Federation Federation { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("SportId")]
        public Sport Sport { get; set; }
    }
}
