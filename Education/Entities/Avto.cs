using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Avto
    {
        [Key]
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Colour { get; set; }

        public int AvtoParkId { get; set; }

        [ForeignKey("AvtoParkId")]
        public AvtoPark AvtoPark { get; set; }
    }
}
