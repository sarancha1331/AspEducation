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
        private readonly IGenericRepository<AvtoPark> avtoParkRepository;
        private readonly IGenericRepository<Employee> employeeRepository;
        private readonly IGenericRepository<Events> eventRepository;
        private readonly IGenericRepository<Experience> experienceRepository;
        private readonly IGenericRepository<Federation> federationRepository;
        private readonly IGenericRepository<Olimpic> olimpicRepository;
        private readonly IGenericRepository<OtherPersonal> otherPersonalRepository;
        private readonly IGenericRepository<Position> positionRepository;
        private readonly IGenericRepository<Salary> salaryRepository;
        private readonly IGenericRepository<School> schoolRepository;
        private readonly IGenericRepository<Sport> sportRepository;
        private readonly IGenericRepository<Sportsman> sportsmanRepository;
        private readonly IGenericRepository<Student> studentRepository;
        private readonly IGenericRepository<Teacher> teacherRepository;
        


        public MainService(
            IGenericRepository<Avto> avtoRepository,
            IGenericRepository<AvtoPark> avtoParkRepository,
            IGenericRepository<Employee> employeeRepository,
            IGenericRepository<Events> eventRepository,
            IGenericRepository<Experience> experienceRepository,
            IGenericRepository<Federation> federationRepository,
            IGenericRepository<Olimpic> olimpicRepository,
            IGenericRepository<OtherPersonal> otherPersonalRepository,
            IGenericRepository<Position> positionRepository,
            IGenericRepository<Salary> salaryRepository,
            IGenericRepository<School> schoolRepository,
            IGenericRepository<Sport> sportRepository,
            IGenericRepository<Sportsman> sportsmanRepository,
            IGenericRepository<Student> studentRepository,
            IGenericRepository<Teacher> teacherRepository
            )
        {
            this.avtoRepository = avtoRepository;
            this.avtoParkRepository = avtoParkRepository;
            this.employeeRepository = employeeRepository;
            this.eventRepository = eventRepository;
            this.experienceRepository = experienceRepository;
            this.federationRepository = federationRepository;
            this.olimpicRepository = olimpicRepository;
            this.otherPersonalRepository = otherPersonalRepository;
            this.positionRepository = positionRepository;
            this.salaryRepository = salaryRepository;
            this.schoolRepository = schoolRepository;
            this.sportRepository = sportRepository;
            this.sportsmanRepository = sportsmanRepository;
            this.studentRepository = studentRepository;
            this.teacherRepository = teacherRepository;
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
