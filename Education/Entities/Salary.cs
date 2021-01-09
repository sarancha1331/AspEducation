using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Entities
{
    /// <summary>
    /// Зарплата
    /// </summary>
    public class Salary : BaseEntity
    {
        public int SalaryNumber { get; set; }
    }
}
