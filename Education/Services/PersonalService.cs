using Education.Entities;
using Education.Interfaces;
using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Services
{
    public class PersonalService : IPersonalService
    {
        private readonly IGenericRepository<Employee> employeeRepository;
        private readonly IGenericRepository<Experience> experienceRepository;
        private readonly IGenericRepository<OtherPersonal> otherPersonalRepository;
        private readonly IGenericRepository<Position> positionRepository;
        private readonly IGenericRepository<Salary> salaryRepository;
        private readonly IGenericRepository<Teacher> teacherRepository;
        
        public PersonalService(
            IGenericRepository<Employee> employeeRepository,
            IGenericRepository<Experience> experienceRepository,       
            IGenericRepository<OtherPersonal> otherPersonalRepository,
            IGenericRepository<Position> positionRepository,
            IGenericRepository<Salary> salaryRepository,
            IGenericRepository<Teacher> teacherRepository
            )
        {
            this.employeeRepository = employeeRepository;
            this.experienceRepository = experienceRepository;
            this.otherPersonalRepository = otherPersonalRepository;
            this.positionRepository = positionRepository;
            this.salaryRepository = salaryRepository;
            this.teacherRepository = teacherRepository;
        }

        public async Task<List<EmployeeGetAllRecords>> GetAllEmployeeAsync()
        {
            List<Employee> avtoPark = await employeeRepository.GetAllAsync();
            List<EmployeeGetAllRecords> resultModel = new List<EmployeeGetAllRecords>();
            foreach (var item in avtoPark)
            {
                resultModel.Add(new EmployeeGetAllRecords
                {
                    DateOfEmployee = item.DateOfEmployee,
                    Specialization = item.Specialization
                });
            }

            return resultModel;
        }

        public async Task<List<ExperienceGetAllRecords>> GetAllExperienceAsync() {
            List<Experience> experience = await experienceRepository.GetAllAsync();
            List<ExperienceGetAllRecords> resultModel = new List<ExperienceGetAllRecords>();
            foreach (var item in experience)
            {
                resultModel.Add(new ExperienceGetAllRecords
                {
                    ExperienceYear = item.ExperienceYear
                });
            }

            return resultModel;
        }

        public async Task<List<OtherPersonalGetAllRecords>> GetAllOtherPersonalAsync()
        {
            List<OtherPersonal> otherPersonal = await otherPersonalRepository.GetAllAsync();
            List<OtherPersonalGetAllRecords> resultModel = new List<OtherPersonalGetAllRecords>();
            foreach (var item in otherPersonal)
            {
                resultModel.Add(new OtherPersonalGetAllRecords
                {
                    FIO = item.FIO
                });
            }

            return resultModel;
        }

        public async Task<List<PositionGetAllRecords>> GetAllPositionAsync()
        {
            List<Position> position = await positionRepository.GetAllAsync();
            List<PositionGetAllRecords> resultModel = new List<PositionGetAllRecords>();
            foreach (var item in position)
            {
                resultModel.Add(new PositionGetAllRecords
                {
                    PositionName = item.PositionName
                });
            }

            return resultModel;
        }

        public async Task<List<SalaryGetAllRecords>> GetAllSalaryAsync()
        {
            List<Salary> salary = await salaryRepository.GetAllAsync();
            List<SalaryGetAllRecords> resultModel = new List<SalaryGetAllRecords>();
            foreach (var item in salary)
            {
                resultModel.Add(new SalaryGetAllRecords
                {
                    SalaryNumber = item.SalaryNumber
                });
            }

            return resultModel;
        }

        public async Task<List<TeacherGetAllRecords>> GetAllTeacherAsync()
        {
            List<Teacher> teacher = await teacherRepository.GetAllAsync();
            List<TeacherGetAllRecords> resultModel = new List<TeacherGetAllRecords>();
            foreach (var item in teacher)
            {
                resultModel.Add(new TeacherGetAllRecords
                {
                    FIO = item.FIO
                });
            }

            return resultModel;
        }


    }
}
