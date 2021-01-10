using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services.Models
{
    public class StudentSupplementedGetAllRecords
    {
        public string FIO { get; set; }

        public string StudentGroup { get; set; }

        public DateTime DataBorn { get; set; }

        public DateTime DateOfEmployee { get; set; }

        public string Specialization { get; set; }
    }
}
