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
    [Authorize]
    public class MenuItemController : Controller
    {
        private readonly IMenuItemService _menuItemService;
        public MenuItemController(IMenuItemService menuItemService)
        {

            _menuItemService = menuItemService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _menuItemService.GetAllMenuItem();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MenuItem model)
        {
            _menuItemService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _menuItemService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _menuItemService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(MenuItem model)
        {
            _menuItemService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _menuItemService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(MenuItem model)
        {
            _menuItemService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}