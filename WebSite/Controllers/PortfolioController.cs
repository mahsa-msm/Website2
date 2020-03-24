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

    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {

            _portfolioService = portfolioService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _portfolioService.GetAllPortfolio();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Portfolio model)
        {
            _portfolioService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _portfolioService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _portfolioService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(Portfolio model)
        {
            _portfolioService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _portfolioService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(Portfolio model)
        {
            _portfolioService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}