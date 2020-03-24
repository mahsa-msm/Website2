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
    public class AboutSliderController : Controller
    {
        private readonly IAboutSliderService _aboutSliderService;
        public AboutSliderController(IAboutSliderService aboutSliderService)
        {

            _aboutSliderService = aboutSliderService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _aboutSliderService.GetAllAboutSlider();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AboutSlider model)
        {
            _aboutSliderService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _aboutSliderService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _aboutSliderService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(AboutSlider model)
        {
            _aboutSliderService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _aboutSliderService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(AboutSlider model)
        {
            _aboutSliderService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}