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
    public class BlogSectionController : Controller
    {

        private readonly IBlogSectionService _BlogSectionService;
        public BlogSectionController(IBlogSectionService BlogSectionService)
        {

            _BlogSectionService = BlogSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _BlogSectionService.GetBlogSection(1);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BlogSection model)
        {
            _BlogSectionService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _BlogSectionService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _BlogSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(BlogSection model)
        {
            _BlogSectionService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _BlogSectionService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(BlogSection model)
        {
            _BlogSectionService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}