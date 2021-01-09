using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Стаж
    /// </summary>
    public class Experience : BaseEntity
    {
        public string ExperienceYear { get; set; }

    }
}
