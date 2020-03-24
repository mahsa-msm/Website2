using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutSlider> AboutSliders { get; set; }
        public DbSet<BanerSlider> BanerSlider { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSection> BlogSections { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactSection> ContactSections { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioSection> PortfolioSections { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceSection> ServiceSections { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSection> TeamSections { get; set; }
        public DbSet<FooterPicture> FooterPictures { get; set; }

    }
}
