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

    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {

            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _blogService.GetAllBlog(3);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog model)
        {
            _blogService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _blogService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _blogService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(Blog model)
        {
            _blogService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _blogService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(Blog model)
        {
            _blogService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}