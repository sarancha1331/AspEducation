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

        Task<List<AvtoParkGetAllRecords>> GetAllAvtoParkAsync();

        Task<List<EmployeeGetAllRecords>> GetAllEmployeeAsync();

        Task<List<EventsGetAllRecords>> GetAllEventsAsync();

        Task<List<ExperienceGetAllRecords>> GetAllExperienceAsync();
        
        Task<List<FederationGetAllRecords>> GetAllFederationAsync();

        Task<List<OlimpicGetAllRecords>> GetAllOlimpicAsync();

        Task<List<OtherPersonalGetAllRecords>> GetAllOtherPersonalAsync();

        Task<List<PositionGetAllRecords>> GetAllPositionAsync();

        Task<List<SalaryGetAllRecords>> GetAllSalaryAsync();

        Task<List<SchoolGetAllRecords>> GetAllSchoolAsync();

        Task<List<SportGetAllRecords>> GetAllSportAsync();

        Task<List<SportsmanGetAllRecords>> GetAllSportsmanAsync();

        Task<List<StudentGetAllRecords>> GetAllStudentAsync();

        Task<List<TeacherGetAllRecords>> GetAllTeacherAsync();
        

    }
}
