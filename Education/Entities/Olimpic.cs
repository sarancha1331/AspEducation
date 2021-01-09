using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Olimpic
    {
        [Key]
        public int Id { get; set; }

        public DateTime OlimpicData { get; set; }

        public string NameOlimpic { get; set; }

        public string Subject { get; set; }
    }
}
