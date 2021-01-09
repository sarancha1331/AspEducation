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

    }
}
