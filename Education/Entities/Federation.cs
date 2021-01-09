using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Federation
    {
        [Key]
        public int Id { get; set; }

        public string FederationName { get; set; }

        public DateTime DataBasis { get; set; }
    }
}
