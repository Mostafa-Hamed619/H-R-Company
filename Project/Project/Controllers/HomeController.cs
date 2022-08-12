using Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Project.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly EmployeeRepository employeeRepository;

        public HomeController(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        public ViewResult Index()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
        }
        [HttpPost]
        public IActionResult Index(newsLetters news)
        {
            if (ModelState.IsValid)
            {
                var add = employeeRepository.Addnews(news);
            }
            return RedirectToAction("Index");
        }

        public ViewResult Services()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
            return View();
        }
        public ViewResult About()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
            return View();
        }
        public ViewResult Blog()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contacting contact)
        {
            var Contact = employeeRepository.AddContact(contact);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Careers()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
           
            return View();
        }
        [HttpPost]
        public IActionResult Careers(Job_App NewApp)
        {
         
            var App = employeeRepository.AddJob(NewApp);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult send()
        {
            var informations = employeeRepository.info(2);
            ViewData["info"] = informations;
            return View();
        }

        [HttpPost]
        public IActionResult send(newsLettersViewModel model)
        {

            return View(model);
        }
    }
}
