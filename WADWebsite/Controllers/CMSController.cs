using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WADWebsite.Models;

namespace WADWebsite.Controllers
{
   
        [Authorize(Roles = "Manager")]
        public class CMSController : Controller { 


        private readonly ILogger<CMSController> _logger;
        private readonly ApplicationDbContext _context;
        private IEnumerable<Festival> Festivals;

        public IActionResult SignIn()
        {
            List<Festival> Model = _context.Festivals.ToList();

            return View(Model);
        }
    }
}
