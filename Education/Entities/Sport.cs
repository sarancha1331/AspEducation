﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Спорт
    /// </summary>
    public class Sport : BaseEntity
    { 
        public string NameSport { get; set; }
    }
}
