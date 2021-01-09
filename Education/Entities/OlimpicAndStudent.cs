using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Олимпиады и студенты
    /// </summary>
    public class OlimpicAndStudent : BaseEntity
    {
        public int OlimpicId { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("OlimpicId")]
        public Olimpic Olimpic { get; set; }

    }
}
