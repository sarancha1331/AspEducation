using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IStudentService
    {
        //Федерации
        Task<List<FederationGetAllRecords>> GetAllFederationAsync();

        //Олимпиады
        Task<List<OlimpicGetAllRecords>> GetAllOlimpicAsync();

        //Виды спорта
        Task<List<SportGetAllRecords>> GetAllSportAsync();

        //Спортсмены
        Task<List<SportsmanGetAllRecords>> GetAllSportsmanAsync();
        Task<List<SportsmanSupplementedGetAllRecords>> GetAllSportsmanSupplementedAsync();

        //Студенты
        Task<List<StudentGetAllRecords>> GetAllStudentAsync();
        Task<List<StudentSupplementedGetAllRecords>> GetAllStudentSupplementedAsync();
    }
}
