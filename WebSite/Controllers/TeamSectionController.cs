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

    public class TeamSectionController : Controller
    {
        private readonly ITeamSectionService _teamSectionService;
        public TeamSectionController(ITeamSectionService teamSectionService)
        {

            _teamSectionService = teamSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _teamSectionService.GetTeamSection(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TeamSection model)
        {
            _teamSectionService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _teamSectionService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _teamSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(TeamSection model)
        {
            _teamSectionService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _teamSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(TeamSection model)
        {
            _teamSectionService.Delete(model);
            return RedirectToAction(nameof(Index));
        }


    }
}