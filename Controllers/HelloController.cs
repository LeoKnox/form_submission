using System;
using Microsoft.AspNetCore.Mvc;
using form_submission.Models;

namespace form_submission
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("write")]
        public IActionResult Create(User user)
        {
            System.Console.WriteLine("$$$$$$running");
            if (ModelState.IsValid)
            {
                return View("NewUser");
            }
            else
            {
                return View("Index");
            }
        }
    }
}