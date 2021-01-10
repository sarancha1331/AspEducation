using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IExternalService
    {
        Task<List<AvtoGetAllRecords>> GetAllAvtoAsync();

        Task<List<AvtoParkGetAllRecords>> GetAllAvtoParkAsync();

        Task<List<EventsGetAllRecords>> GetAllEventsAsync();

        Task<List<SchoolGetAllRecords>> GetAllSchoolAsync();

    }
}
