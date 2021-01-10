﻿using Education.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Controllers
{
    public class PartialController : Controller
    {
        private readonly IExternalService externalService;
        private readonly IStudentService studentService;
        private readonly IPersonalService personalService;
        public PartialController(IExternalService externalService, IStudentService studentService, IPersonalService personalService)
        {
            this.externalService = externalService;
            this.studentService = studentService;
            this.personalService = personalService;
        }

        public async Task<IActionResult> Avto()
        {
            ViewBag.Result = await externalService.GetAllAvtoAsync();
            return View();
        }

        public async Task<IActionResult> AvtoPark()
        {
            ViewBag.Result = await externalService.GetAllAvtoParkAsync();
            return View();
        }

        public async Task<IActionResult> Employee()
        {
            ViewBag.Result = await personalService.GetAllEmployeeAsync();
            return View();
        }

        public async Task<IActionResult> Event()
        {
            ViewBag.Result = await externalService.GetAllEventsAsync();
            return View();
        }

        public async Task<IActionResult> Experience()
        {
            ViewBag.Result = await personalService.GetAllExperienceAsync();
            return View();
        }

        public async Task<IActionResult> Federation()
        {
            ViewBag.Result = await studentService.GetAllFederationAsync();
            return View();
        }

        public async Task<IActionResult> Olimpic()
        {
            ViewBag.Result = await studentService.GetAllOlimpicAsync();
            return View();
        }

        public async Task<IActionResult> OtherPersonal()
        {
            ViewBag.Result = await personalService.GetAllOtherPersonalAsync();
            return View();
        }

        public async Task<IActionResult> Position()
        {
            ViewBag.Result = await personalService.GetAllPositionAsync();
            return View();
        }

        public async Task<IActionResult> Salary()
        {
            ViewBag.Result = await personalService.GetAllSalaryAsync();
            return View();
        }

        public async Task<IActionResult> School()
        {
            ViewBag.Result = await externalService.GetAllSchoolAsync();
            return View();
        }

        public async Task<IActionResult> Sport()
        {
            ViewBag.Result = await studentService.GetAllSportAsync();
            return View();
        }

        public async Task<IActionResult> Sportsman()
        {
            ViewBag.Result = await studentService.GetAllSportsmanAsync();
            return View();
        }

        public async Task<IActionResult> Student()
        {
            ViewBag.Result = await studentService.GetAllStudentAsync();
            return View();
        }

        public async Task<IActionResult> Teacher()
        {
            ViewBag.Result = await personalService.GetAllTeacherAsync();
            return View();
        }

    }
}
