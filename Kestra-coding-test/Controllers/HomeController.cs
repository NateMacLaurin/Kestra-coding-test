using Kestra_coding_test.Data;
using Kestra_coding_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Kestra_coding_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            //populating the ViewBag on Home/Index load to avoid null SelectListItem error
            IEnumerable<SelectListItem> dropdownObjList = _db.FormDropdownOptions.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.SelectorValue
            });

            ViewBag.Dropdown = dropdownObjList;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
