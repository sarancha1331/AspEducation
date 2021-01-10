using Education.Entities;
using Education.Interfaces;
using Education.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services
{
    public class ExternalService : IExternalService
    {
        private readonly IGenericRepository<Avto> avtoGenericRepository;
        private readonly IGenericRepository<AvtoPark> avtoParkGenericParkRepository;
        private readonly IGenericRepository<Events> eventGenericRepository;
        private readonly IGenericRepository<School> schoolGenericRepository;

        public ExternalService(
            IGenericRepository<Avto> avtoGenericRepository,
            IGenericRepository<AvtoPark> avtoParkGenericRepository,
            IGenericRepository<Events> eventGenericRepository,
            IGenericRepository<School> schoolGenericRepository
            )
        {
            this.avtoGenericRepository = avtoGenericRepository;
            this.avtoParkGenericParkRepository = avtoParkGenericRepository;
            this.eventGenericRepository = eventGenericRepository;
            this.schoolGenericRepository = schoolGenericRepository;
        }

        /// <summary>
        /// Частичное представление всех авто
        /// </summary>
        public async Task<List<AvtoGetAllRecords>> GetAllAvtoAsync()    //+
        {
            List<Avto> avtos = await avtoGenericRepository.GetAllAsync();
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

        /// <summary>
        /// Полное представление Авто и Автопарков в которых они находятся
        /// </summary>
        public async Task<List<AvtoSupplementedGetAllRecords>> GetAllAvtoSupplementedAsync()    //+
        {
            List<Avto> avto = await avtoGenericRepository.AsQueryable()
                .Include(l => l.AvtoPark)
                .ToListAsync();
            List<AvtoSupplementedGetAllRecords> resultModel = new List<AvtoSupplementedGetAllRecords>();
            foreach (var item in avto)
            {
                resultModel.Add(new AvtoSupplementedGetAllRecords
                {
                    Marka = item.Marka,
                    Colour = item.Colour,
                    Address = item.AvtoPark.Address,
                    ParkSize = item.AvtoPark.ParkSize
                });
            }

            return resultModel;
        }

        /// <summary>
        /// Частичное представление всех автопарков
        /// </summary>
        public async Task<List<AvtoParkGetAllRecords>> GetAllAvtoParkAsync() {  //+
            List<AvtoPark> avtoPark = await avtoParkGenericParkRepository.GetAllAsync();
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

        /// <summary>
        /// Полное представление всех Автопарков и школ к которым они закреплены
        /// </summary>
        public async Task<List<AvtoParkSupplementedGetAllRecords>> GetAllAvtoParkSupplementedAsync()    //+
        {
            List<AvtoPark> avtoPark = await avtoParkGenericParkRepository.AsQueryable()
                .Include(l => l.School)
                .ToListAsync();
            List<AvtoParkSupplementedGetAllRecords> resultModel = new List<AvtoParkSupplementedGetAllRecords>();
            foreach (var item in avtoPark)
            {
                resultModel.Add(new AvtoParkSupplementedGetAllRecords
                {
                    AddressAvtoPark = item.Address,
                    ParkSize = item.ParkSize,
                    Name = item.School.Name,
                    AddressSchool = item.School.Address
                });
            }

            return resultModel;
        }

        /// <summary>
        /// Частичное представление всех Событий
        /// </summary>
        public async Task<List<EventsGetAllRecords>> GetAllEventsAsync() {
            List<Events> events = await eventGenericRepository.GetAllAsync();
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

        /// <summary>
        /// Полное представление всех Событий и Школ в которых они проводятся
        /// </summary>
        public async Task<List<EventsSupplementedGetAllRecords>> GetAllEventsSupplementedAsync()
        {
            List<Events> events = await eventGenericRepository.AsQueryable()
                .Include(l => l.School)
                .ToListAsync();
            List<EventsSupplementedGetAllRecords> resultModel = new List<EventsSupplementedGetAllRecords>();
            foreach (var item in events)
            {
                resultModel.Add(new EventsSupplementedGetAllRecords
                {
                    NameEvent = item.NameEvent,
                    DataEvent = item.DataEvent,
                    Name = item.School.Name,
                    Address = item.School.Name
                });
            }

            return resultModel;
        }

        /// <summary>
        /// Частичное и оно же полное представление всех школ
        /// </summary>
        public async Task<List<SchoolGetAllRecords>> GetAllSchoolAsync()    //+
        {
            List<School> school = await schoolGenericRepository.GetAllAsync();
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
