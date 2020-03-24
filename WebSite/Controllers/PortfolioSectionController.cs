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

    public class PortfolioSectionController : Controller
    {
        private readonly IPortfolioSectionService _portfolioSectionService;
        public PortfolioSectionController(IPortfolioSectionService portfolioSectionService)
        {

            _portfolioSectionService = portfolioSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _portfolioSectionService.GetPortfolioSection(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PortfolioSection model)
        {
            _portfolioSectionService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _portfolioSectionService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _portfolioSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(PortfolioSection model)
        {
            _portfolioSectionService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _portfolioSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(PortfolioSection model)
        {
            _portfolioSectionService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}