using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnyana.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            TempData["key"] = "Data from Index Methods";
            return View();
        }

       
    }
}
