using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Service.Interface;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]

    public class ContactSectionController : Controller
    {
        private readonly IContactSectionService _contactSectionService;
        public ContactSectionController(IContactSectionService contactSectionService)
        {

            _contactSectionService = contactSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _contactSectionService.GetcontactSection(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactSection model)
        {
            _contactSectionService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _contactSectionService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _contactSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(ContactSection model)
        {
            _contactSectionService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _contactSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(ContactSection model)
        {
            _contactSectionService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}