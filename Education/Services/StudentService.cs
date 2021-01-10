using Education.Entities;
using Education.Interfaces;
using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Olimpic> olimpicRepository;
        private readonly IGenericRepository<Sport> sportRepository;
        private readonly IGenericRepository<Federation> federationRepository;
        private readonly IGenericRepository<Sportsman> sportsmanRepository;
        private readonly IGenericRepository<Student> studentRepository;
        private readonly IGenericRepository<OlimpicAndStudent> olimpicAndStudentRepository;

        public StudentService(
            IGenericRepository<Federation> federationRepository,
            IGenericRepository<Olimpic> olimpicRepository,
            IGenericRepository<Sport> sportRepository,
            IGenericRepository<Student> studentRepository,
            IGenericRepository<Sportsman> sportsmanRepository,
            IGenericRepository<OlimpicAndStudent> olimpicAndStudentRepository
            )
        {
            this.federationRepository = federationRepository;
            this.olimpicRepository = olimpicRepository;
            this.sportRepository = sportRepository;
            this.sportsmanRepository = sportsmanRepository;
            this.studentRepository = studentRepository;
            this.olimpicAndStudentRepository = olimpicAndStudentRepository;
        }

        public async Task<List<FederationGetAllRecords>> GetAllFederationAsync()
        {
            List<Federation> federation = await federationRepository.GetAllAsync();
            List<FederationGetAllRecords> resultModel = new List<FederationGetAllRecords>();
            foreach (var item in federation)
            {
                resultModel.Add(new FederationGetAllRecords
                {
                    FederationName = item.FederationName,
                    DataBasis = item.DataBasis
                });
            }

            return resultModel;
        }

        public async Task<List<OlimpicGetAllRecords>> GetAllOlimpicAsync()
        {
            List<Olimpic> federation = await olimpicRepository.GetAllAsync();
            List<OlimpicGetAllRecords> resultModel = new List<OlimpicGetAllRecords>();
            foreach (var item in federation)
            {
                resultModel.Add(new OlimpicGetAllRecords
                {
                NameOlimpic = item.NameOlimpic,
                Subject = item.Subject,
                OlimpicData = item.OlimpicData
                });
            }

            return resultModel;
        }

        public async Task<List<SportGetAllRecords>> GetAllSportAsync()
        {
            List<Sport> sport= await sportRepository.GetAllAsync();
            List<SportGetAllRecords> resultModel = new List<SportGetAllRecords>();
            foreach (var item in sport)
            {
                resultModel.Add(new SportGetAllRecords
                {
                    NameSport = item.NameSport
                });
            }

            return resultModel;
        }

        public async Task<List<SportsmanGetAllRecords>> GetAllSportsmanAsync()
        {
            List<Sportsman> sportsman = await sportsmanRepository.GetAllAsync();
            List<SportsmanGetAllRecords> resultModel = new List<SportsmanGetAllRecords>();
            foreach (var item in sportsman)
            {
                resultModel.Add(new SportsmanGetAllRecords
                {
                    Status = item.Status
                });
            }

            return resultModel;
        }

        public async Task<List<StudentGetAllRecords>> GetAllStudentAsync()
        {
            List<Student> student = await studentRepository.GetAllAsync();
            List<StudentGetAllRecords> resultModel = new List<StudentGetAllRecords>();
            foreach (var item in student)
            {
                resultModel.Add(new StudentGetAllRecords
                {
                    FIO = item.FIO,
                    StudentGroup = item.StudentGroup,
                    DataBorn = item.DataBorn
                });
            }

            return resultModel;
        }


    }
}
