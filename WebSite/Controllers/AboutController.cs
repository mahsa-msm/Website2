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
    [Authorize(Roles="Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {

            _aboutService = aboutService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _aboutService.GetAllAbout(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(About model)
        {
            _aboutService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _aboutService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _aboutService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(About model)
        {
            _aboutService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _aboutService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(About model)
        {
            _aboutService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}