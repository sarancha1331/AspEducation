using Education.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Interfaces
{
    public interface IStudentService
    {
        Task<List<FederationGetAllRecords>> GetAllFederationAsync();

        Task<List<OlimpicGetAllRecords>> GetAllOlimpicAsync();

        Task<List<SportGetAllRecords>> GetAllSportAsync();

        Task<List<SportsmanGetAllRecords>> GetAllSportsmanAsync();

        Task<List<StudentGetAllRecords>> GetAllStudentAsync();
    }
}
