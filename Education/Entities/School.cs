using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Школа
    /// </summary>
    public class School : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
