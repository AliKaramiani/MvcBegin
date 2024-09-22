using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Azure.Core.HttpHeader;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ListStudent()
        {
            List<string> students = new List<string> { "hasan", "ali", "mohammad", "asghar" };
            return View(students);
        }
        public IActionResult index(string name,int id,int age)
        {
             ViewBag.Name=name;
            ViewBag.Id = id;
           ViewBag.Age=age;
          
            return View();
        }


    }
}