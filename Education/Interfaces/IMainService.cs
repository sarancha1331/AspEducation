using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IMainService
    {
        Task<List<AvtoGetAllRecords>> GetAllAvtoAsync();

        Task<List<AvtoGetAllRecords>> GetAllAvtoParkAsync();

    }
}
