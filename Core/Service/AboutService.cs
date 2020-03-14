using Core.Service.Interface;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class AboutService : IAboutService
    {
        private readonly WebsiteContext _context;
        public AboutService(WebsiteContext context)
        {
            _context = context;
        }
        public async Task<List<About>> GetAllAbout(int take = 1)
        {
            return await _context.Abouts.Take(take).ToListAsync();
        }
        public void Add(About about)
        {
            _context.Add(about);
            _context.SaveChanges();
        }
        public About FindById(int Id)
        {
            return _context.Abouts.Find(Id);
        }
        public void Edit(About about)
        {
            _context.Entry(about).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(About about)
        {
            _context.Entry(about).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }


    }
}
