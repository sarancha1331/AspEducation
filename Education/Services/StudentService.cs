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
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Olimpic> olimpicRepository;
        private readonly IGenericRepository<Sport> sportRepository;
        private readonly IGenericRepository<Federation> federationRepository;
        private readonly IGenericRepository<Sportsman> sportsmanRepository;
        private readonly IGenericRepository<Student> studentRepository;

        public StudentService(
            IGenericRepository<Federation> federationRepository,
            IGenericRepository<Olimpic> olimpicRepository,
            IGenericRepository<Sport> sportRepository,
            IGenericRepository<Student> studentRepository,
            IGenericRepository<Sportsman> sportsmanRepository
            )
        {
            this.federationRepository = federationRepository;
            this.olimpicRepository = olimpicRepository;
            this.sportRepository = sportRepository;
            this.sportsmanRepository = sportsmanRepository;
            this.studentRepository = studentRepository;
        }

        public async Task<List<FederationGetAllRecords>> GetAllFederationAsync()    //+
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

        public async Task<List<OlimpicGetAllRecords>> GetAllOlimpicAsync()  //+
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

        public async Task<List<SportGetAllRecords>> GetAllSportAsync()  //+
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

        public async Task<List<SportsmanSupplementedGetAllRecords>> GetAllSportsmanSupplementedAsync() {    //+
            List<Sportsman> sportsman = await sportsmanRepository.AsQueryable()
                .Include(l => l.Federation)
                .Include(q => q.Sport)
                .Include(q => q.Student)
                .ToListAsync();
            List<SportsmanSupplementedGetAllRecords> resultModel = new List<SportsmanSupplementedGetAllRecords>();
            foreach (var item in sportsman)
            {
                resultModel.Add(new SportsmanSupplementedGetAllRecords
                {
                    FIO = item.Student.FIO,
                    Status = item.Status,
                    FederationName = item.Federation.FederationName,
                    DataBasis = item.Federation.DataBasis,
                    NameSport = item.Sport.NameSport
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

        public async Task<List<StudentSupplementedGetAllRecords>> GetAllStudentSupplementedAsync() {
            List<Student> student = await studentRepository.AsQueryable()
                .Include(l => l.Employee)
                .ToListAsync();
            List<StudentSupplementedGetAllRecords> resultModel = new List<StudentSupplementedGetAllRecords>();
            foreach (var item in student)
            {
                resultModel.Add(new StudentSupplementedGetAllRecords
                {
                    FIO = item.FIO,
                    StudentGroup = item.StudentGroup,
                    DataBorn = item.DataBorn,
                    DateOfEmployee = item.Employee.DateOfEmployee,
                    Specialization = item.Employee.Specialization
                });
            }

            return resultModel;
        }

    }
}
