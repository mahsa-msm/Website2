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
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {

            _teamService = teamService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _teamService.GetAllTeam();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Team model)
        {
            _teamService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _teamService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _teamService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(Team model)
        {
            _teamService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _teamService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(Team model)
        {
            _teamService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}