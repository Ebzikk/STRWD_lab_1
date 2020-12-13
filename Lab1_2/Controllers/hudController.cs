using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab1_2.Models;

namespace lab1_2.Controllers
{
    public class hudController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string straight)
        {
            string result = "";
            switch(straight)
            {
                case "Їхав козак за Дунай":
                    result += "Семен Климовський";
                    break;
                case "Повчання дітям":
                    result += "Володимир Мономах";
                    break;
                case "Соловейко":
                    result += "М. Костомаров";
                    break;
            }
            return Content(result);
        }

    }
}
