using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models.Home;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("/result")]
        public IActionResult Result(User survey)
        {
            // ViewBag.StudentName = name;
            // ViewBag.Location = location;
            // ViewBag.FavLanguage = language;
            // ViewBag.Comment = comment;
            if (ModelState.IsValid)
            {
                return View(survey);
            }
            else
            {
                return View("Index");
            }
        }
    }
}