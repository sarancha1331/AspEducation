﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }

        public string NameSport { get; set; }
    }
}
