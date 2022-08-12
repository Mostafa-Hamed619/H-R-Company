using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Authorize]
    public class AdministrationController : Controller
    {
        private readonly EmployeeRepository employeeRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        

        public AdministrationController(EmployeeRepository employeeRepository,UserManager<IdentityUser> userManager,
                                        SignInManager<IdentityUser> signInManager)
        {
            this.employeeRepository = employeeRepository;
            this.userManager = userManager;
            this.signInManager = signInManager;
           
        }
        
        
        public IActionResult Controlpanel()
        {
            var contact = employeeRepository.showcontact();
            var NewsLetter = employeeRepository.showNewsLetters();
            var JobApplication = employeeRepository.showJobApps();

            ViewData["contact"] = contact;
            ViewData["NewsLetter"] = NewsLetter;
            ViewData["App"] = JobApplication;
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            information info = employeeRepository.info(2);
            EditInformationViewModel model = new EditInformationViewModel
            {
                id = info.id,
                Country = info.Country,
                City = info.City,
                EmaiAddress = info.EmaiAddress,
                Phone = info.Phone,
                Street = info.Street
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditInformationViewModel model)
        {
            if (ModelState.IsValid)
            {
                information info = employeeRepository.info(model.id);
                info.Phone = model.Phone;
                info.EmaiAddress = model.EmaiAddress;
                info.Country = model.Country;
                info.City = model.City;
                info.Street = model.Street;

                var informationUpdated = employeeRepository.UpdateInfo(info);
                return RedirectToAction("Controlpanel","Administration");
            }
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = model.Name,
                    Email = model.EmailAddress
                };
                var result =await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Controlpanel", "Administration");
                }
                else
                {
                    foreach (var erro in result.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);
                    }
                }
            }
            return View();
        }

     
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}
