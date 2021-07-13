using Kestra_coding_test.Data;
using Kestra_coding_test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Kestra_coding_test.Controllers
{
    public class FormDataController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FormDataController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET - INDEX (Default)
        public IActionResult Index()
        {
            IEnumerable<FormData> objList = _db.FormData;

            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FormData obj)
        {
            obj.Location = Request.Form["Dropdown"];
            _db.FormData.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult FormDropdownOptions()
        {
            IEnumerable<FormDropdownOptions> dropdownObjList = _db.FormDropdownOptions;

            return View(dropdownObjList);
        }
    }
}