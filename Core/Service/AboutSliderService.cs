using Core.Service.Interface;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class AboutSliderService : IAboutSliderService
    {
        private readonly ApplicationDbContext _context;
        public AboutSliderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<AboutSlider>> GetAllAboutSlider()
        {
            return await _context.AboutSliders.ToListAsync();
        }
        public void Add(AboutSlider aboutSlider)
        {
            _context.Add(aboutSlider);
            _context.SaveChanges();
        }
        public AboutSlider FindById(int Id)
        {
            return _context.AboutSliders.Find(Id);
        }
        public void Edit(AboutSlider aboutSlider)
        {
            _context.Entry(aboutSlider).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(AboutSlider aboutSlider)
        {
            _context.Entry(aboutSlider).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

    }
}
