using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Context
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext(DbContextOptions<WebsiteContext> options) : base(options)
        {

        }
        #region Abouts
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutSlider> AboutSliders { get; set; }
        #endregion
        #region Home
        public DbSet<BanerSlider> BanerSlider { get; set; }
        #endregion
        #region Blog
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSection> BlogSections { get; set; }
        #endregion
        #region Contact
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactSection> ContactSections { get; set; }
        #endregion
        #region MenuItem
        public DbSet<MenuItem> MenuItems { get; set; }
        #endregion
        #region Portfolio
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioSection> PortfolioSections { get; set; }
        #endregion
        #region Service
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceSection> ServiceSections { get; set; }
        #endregion
        #region Team
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSection> TeamSections { get; set; }
        #endregion
        #region Footer
        public DbSet<FooterPicture> FooterPictures { get; set; }

        #endregion

    }
}
