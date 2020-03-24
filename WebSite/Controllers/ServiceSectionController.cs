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

    public class ServiceSectionController : Controller
    {
        private readonly IServiceSectionService _serviceSectionService;
        public ServiceSectionController(IServiceSectionService serviceSectionService)
        {

            _serviceSectionService = serviceSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _serviceSectionService.GetServiceSection(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ServiceSection model)
        {
            _serviceSectionService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _serviceSectionService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _serviceSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(ServiceSection model)
        {
            _serviceSectionService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _serviceSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(ServiceSection model)
        {
            _serviceSectionService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}