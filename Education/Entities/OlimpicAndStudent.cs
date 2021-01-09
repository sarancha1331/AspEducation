using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class OlimpicAndStudent
    {
        [Key]
        public int Id { get; set; }

        public int OlimpicId { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("OlimpicId")]
        public Olimpic Olimpic { get; set; }

    }
}
