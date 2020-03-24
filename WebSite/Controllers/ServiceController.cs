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

    public class ServiceController : Controller

    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {

            _serviceService = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _serviceService.GetAllService(5);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Services model)
        {
            _serviceService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _serviceService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _serviceService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(Services model)
        {
            _serviceService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _serviceService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(Services model)
        {
            _serviceService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}