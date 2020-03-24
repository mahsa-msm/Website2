using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSite.Models;

namespace WebSite.Controllers
{
   

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
      
        private readonly IAboutService _aboutService;
        private readonly IAboutSliderService _aboutSliderService;
        private readonly IBanerSliderService _banerSliderService;
        private readonly IBlogService _Blogservice;
        private readonly IBlogSectionService _BlogSectionService;
        private readonly IContactService _contactService;
        private readonly IContactSectionService _contactSectionService;
        private readonly IFooterPictureService _footerPictureService;
        private readonly IMenuItemService _menuItemService;
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioSectionService _portfolioSectionService;
        private readonly IServiceService _serviceService;
        private readonly IServiceSectionService _serviceSectionService;
        private readonly ITeamService _teamService;
        private readonly ITeamSectionService _teamSectionService;

        public HomeController(ILogger<HomeController> logger, IAboutService aboutService, IAboutSliderService aboutSliderService,
        IBanerSliderService banerSliderService, IBlogService blogService, IBlogSectionService BlogSectionService,
         IContactService contactService, IContactSectionService contactSectionService, IFooterPictureService footerPictureService, IMenuItemService menuItemService
        , IPortfolioService portfolioService, IPortfolioSectionService portfolioSectionService, IServiceService serviceService
      , IServiceSectionService serviceSectionService, ITeamService teamService, ITeamSectionService teamSectionService)
        {
            _logger = logger;
            _aboutService = aboutService;
            _aboutSliderService = aboutSliderService;
            _banerSliderService = banerSliderService;
            _Blogservice = blogService;
            _BlogSectionService = BlogSectionService;
            _contactService = contactService;
            _contactSectionService = contactSectionService;
            _footerPictureService = footerPictureService;
            _menuItemService = menuItemService;
            _portfolioService = portfolioService;
            _portfolioSectionService = portfolioSectionService;
            _serviceService = serviceService;
            _serviceSectionService = serviceSectionService;
            _teamService = teamService;
            _teamSectionService = teamSectionService;

        }

        public async Task<IActionResult> Index()
        {

            ViewData["About"] = await _aboutService.GetAllAbout(1);
            ViewData["AboutSlider"] = await _aboutSliderService.GetAllAboutSlider();
            ViewData["BanerSlider"] = await _banerSliderService.GetAllBanerSlider();
            ViewData["Blog"] = await _Blogservice.GetAllBlog(3);
            ViewData["BlogSection"] = await _BlogSectionService.GetBlogSection(1);
            ViewData["Contact"] = await _contactService.GetContact(1);
            ViewData["ContactSection"] = await _contactSectionService.GetcontactSection(1);
            ViewData["FooterPicture"] = await _footerPictureService.GetAllFooterPicture();
            ViewData["MenuItem"] = await _menuItemService.GetAllMenuItem();
            ViewData["Portfolio"] = await _portfolioService.GetAllPortfolio();
            ViewData["PortfolioSection"] = await _portfolioSectionService.GetPortfolioSection(1);
            ViewData["Service"] = await _serviceService.GetAllService(5);
            ViewData["ServiceSection"] = await _serviceSectionService.GetServiceSection(1);
            ViewData["Team"] = await _teamService.GetAllTeam();
            ViewData["TeamSection"] = await _teamSectionService.GetTeamSection(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
