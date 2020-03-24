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

    public class FooterPictureController : Controller
    {
        private readonly IFooterPictureService _footerPictureService;
        public FooterPictureController(IFooterPictureService footerPictureService)
        {

            _footerPictureService = footerPictureService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _footerPictureService.GetAllFooterPicture();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FooterPicture model)
        {
            _footerPictureService.Add(model);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Details(int id)
        {
            var model = _footerPictureService.FindById(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _footerPictureService.FindById(id);
            return View(model);
        }
        public IActionResult Edit(FooterPicture model)
        {
            _footerPictureService.Edit(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _footerPictureService.FindById(id);
            return View(model);
        }
        public IActionResult Delete(FooterPicture model)
        {
            _footerPictureService.Delete(model);
            return RedirectToAction(nameof(Index));
        }
    }
}