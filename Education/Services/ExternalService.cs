using Education.Entities;
using Education.Interfaces;
using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services
{
    public class ExternalService : IExternalService
    {
        private readonly IGenericRepository<Avto> avtoRepository;
        private readonly IGenericRepository<AvtoPark> avtoParkRepository;
        private readonly IGenericRepository<Events> eventRepository;
        private readonly IGenericRepository<School> schoolRepository;
        
        public ExternalService(
            IGenericRepository<Avto> avtoRepository,
            IGenericRepository<AvtoPark> avtoParkRepository,
            IGenericRepository<Events> eventRepository,
            IGenericRepository<School> schoolRepository
            )
        {
            this.avtoRepository = avtoRepository;
            this.avtoParkRepository = avtoParkRepository;
            this.eventRepository = eventRepository;
            this.schoolRepository = schoolRepository;
        }

        public async Task<List<AvtoGetAllRecords>> GetAllAvtoAsync()
        {
            List<Avto> avtos = await avtoRepository.GetAllAsync();
            List<AvtoGetAllRecords> resultModel = new List<AvtoGetAllRecords>();
            foreach (var item in avtos)
            {
                resultModel.Add(new AvtoGetAllRecords
                {
                    Marka = item.Marka,
                    Colour = item.Colour
                });
            }

            return resultModel;
        }

        public async Task<List<AvtoParkGetAllRecords>> GetAllAvtoParkAsync() {
            List<AvtoPark> avtoPark = await avtoParkRepository.GetAllAsync();
            List<AvtoParkGetAllRecords> resultModel = new List<AvtoParkGetAllRecords>();
            foreach (var item in avtoPark)
            {
                resultModel.Add(new AvtoParkGetAllRecords
                {
                    Address = item.Address,
                    ParkSize = item.ParkSize
                });
            }

            return resultModel;
        }

        public async Task<List<EventsGetAllRecords>> GetAllEventsAsync() {
            List<Events> events = await eventRepository.GetAllAsync();
            List<EventsGetAllRecords> resultModel = new List<EventsGetAllRecords>();
            foreach (var item in events)
            {
                resultModel.Add(new EventsGetAllRecords
                {
                    NameEvent = item.NameEvent,
                    DataEvent = item.DataEvent
                });
            }

            return resultModel;
        }

        public async Task<List<SchoolGetAllRecords>> GetAllSchoolAsync()
        {
            List<School> school = await schoolRepository.GetAllAsync();
            List<SchoolGetAllRecords> resultModel = new List<SchoolGetAllRecords>();
            foreach (var item in school)
            {
                resultModel.Add(new SchoolGetAllRecords
                {
                    Name = item.Name,
                    Address = item.Address
                });
            }

            return resultModel;
        }

    }
}
