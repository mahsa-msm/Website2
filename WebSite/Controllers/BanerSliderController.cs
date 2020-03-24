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

    public class BanerSliderController : Controller

    {
        private readonly IBanerSliderService _banerSliderService;
        public BanerSliderController(IBanerSliderService banerSliderService)
        {

            _banerSliderService = banerSliderService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _banerSliderService.GetAllBanerSlider();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BanerSlider model)
        {
            _banerSliderService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _banerSliderService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _banerSliderService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(BanerSlider model)
        {
            _banerSliderService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _banerSliderService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(BanerSlider model)
        {
            _banerSliderService.Delete(model);
            return RedirectToAction(nameof(Index));
        }

    }
}