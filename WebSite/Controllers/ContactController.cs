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

    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {

            _contactService = contactService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _contactService.GetContact(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            _contactService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _contactService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _contactService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(Contact model)
        {
            _contactService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _contactService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}