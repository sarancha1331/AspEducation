using Education.Entities;
using Education.Interfaces;
using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services
{
    public class MainService : IMainService
    {
        private readonly IGenericRepository<Avto> avtoRepository;

        public MainService(IGenericRepository<Avto> avtoRepository)
        {
            this.avtoRepository = avtoRepository;
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

    }
}
