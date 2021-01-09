using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Федерация
    /// </summary>
    public class Federation : BaseEntity
    {
        public string FederationName { get; set; }

        public DateTime DataBasis { get; set; }
    }
}
