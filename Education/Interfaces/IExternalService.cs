using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IExternalService
    {
        //Авто
        Task<List<AvtoGetAllRecords>> GetAllAvtoAsync();    //Частичное представление всех авто
        Task<List<AvtoSupplementedGetAllRecords>> GetAllAvtoSupplementedAsync();    //Полное представление всех авто

        //Автопарки
        Task<List<AvtoParkGetAllRecords>> GetAllAvtoParkAsync();
        Task<List<AvtoParkSupplementedGetAllRecords>> GetAllAvtoParkSupplementedAsync();

        //События
        Task<List<EventsGetAllRecords>> GetAllEventsAsync();
        Task<List<EventsSupplementedGetAllRecords>> GetAllEventsSupplementedAsync();

        //Школы
        Task<List<SchoolGetAllRecords>> GetAllSchoolAsync();

    }
}
