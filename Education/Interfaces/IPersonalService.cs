using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IPersonalService
    {
        Task<List<EmployeeGetAllRecords>> GetAllEmployeeAsync();

        Task<List<ExperienceGetAllRecords>> GetAllExperienceAsync();
        
        Task<List<OtherPersonalGetAllRecords>> GetAllOtherPersonalAsync();

        Task<List<PositionGetAllRecords>> GetAllPositionAsync();

        Task<List<SalaryGetAllRecords>> GetAllSalaryAsync();

        Task<List<TeacherGetAllRecords>> GetAllTeacherAsync();
        

    }
}
