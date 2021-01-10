using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IPersonalService
    {
        //Сотрудники
        Task<List<EmployeeGetAllRecords>> GetAllEmployeeAsync();
        Task<List<EmployeeSupplementedGetAllRecords>> GetAllEmployeeSupplementedAsync();

        //Стаж
        Task<List<ExperienceGetAllRecords>> GetAllExperienceAsync();
        
        //Другой персонал
        Task<List<OtherPersonalGetAllRecords>> GetAllOtherPersonalAsync();
        Task<List<OtherPersonalSupplementedGetAllRecords>> GetAllOtherPersonalSupplementedAsync();

        //Должность
        Task<List<PositionGetAllRecords>> GetAllPositionAsync();
        Task<List<PositionSupplementedGetAllRecords>> GetAllPositionSupplementedAsync();

        //Зарплата
        Task<List<SalaryGetAllRecords>> GetAllSalaryAsync();

        //Учителя
        Task<List<TeacherGetAllRecords>> GetAllTeacherAsync();
        Task<List<TeacherSupplementedGetAllRecords>> GetAllTeacherSupplementedAsync();


    }
}
