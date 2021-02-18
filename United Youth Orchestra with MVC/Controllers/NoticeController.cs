using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using United_Youth_Orchestra_with_MVC.Data;
using UYO_Final.Models;

namespace UYO_Final.Controllers
{
    // Login only to view entire page
    [Authorize]
    public class Notice : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
