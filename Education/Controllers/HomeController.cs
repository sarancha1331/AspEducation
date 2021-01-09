using Education.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainService mainService;
        public HomeController(IMainService ims)
        {
            mainService = ims;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Avto()
        {
            ViewBag.Result = await mainService.GetAllAvtoAsync();
            return View();
        }

        public async Task<IActionResult> AvtoPark()
        {
            ViewBag.Result = await mainService.GetAllAvtoParkAsync();
            return View();
        }

        public async Task<IActionResult> Employee()
        {
            ViewBag.Result = await mainService.GetAllEmployeeAsync();
            return View();
        }

        public async Task<IActionResult> Event()
        {
            ViewBag.Result = await mainService.GetAllEventsAsync();
            return View();
        }

        public async Task<IActionResult> Experience()
        {
            ViewBag.Result = await mainService.GetAllExperienceAsync();
            return View();
        }

        public async Task<IActionResult> Federation()
        {
            ViewBag.Result = await mainService.GetAllFederationAsync();
            return View();
        }

        public async Task<IActionResult> Olimpic()
        {
            ViewBag.Result = await mainService.GetAllOlimpicAsync();
            return View();
        }

        public async Task<IActionResult> OtherPersonal()
        {
            ViewBag.Result = await mainService.GetAllOtherPersonalAsync();
            return View();
        }

        public async Task<IActionResult> Position()
        {
            ViewBag.Result = await mainService.GetAllPositionAsync();
            return View();
        }

        public async Task<IActionResult> Salary()
        {
            ViewBag.Result = await mainService.GetAllSalaryAsync();
            return View();
        }

        public async Task<IActionResult> School()
        {
            ViewBag.Result = await mainService.GetAllSchoolAsync();
            return View();
        }

        public async Task<IActionResult> Sport()
        {
            ViewBag.Result = await mainService.GetAllSportAsync();
            return View();
        }

        public async Task<IActionResult> Sportsman()
        {
            ViewBag.Result = await mainService.GetAllSportsmanAsync();
            return View();
        }

        public async Task<IActionResult> Student()
        {
            ViewBag.Result = await mainService.GetAllStudentAsync();
            return View();
        }

        public async Task<IActionResult> Teacher()
        {
            ViewBag.Result = await mainService.GetAllTeacherAsync();
            return View();
        }

    }
}
