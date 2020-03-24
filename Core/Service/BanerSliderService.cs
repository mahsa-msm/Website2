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
    public class BanerSliderService : IBanerSliderService
    {

        private readonly ApplicationDbContext _context;
        public BanerSliderService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<BanerSlider>> GetAllBanerSlider()
        {
            return await _context.BanerSlider.ToListAsync();
        }
        public void Add(BanerSlider banerSlider)
        {
            _context.Add(banerSlider);
            _context.SaveChanges();

        }
        public BanerSlider FindById(int Id)
        {
            return _context.BanerSlider.Find(Id);
        }
        public void Edit(BanerSlider banerSlider)
        {
            _context.Entry(banerSlider).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(BanerSlider banerSlider)
        {
            _context.Entry(banerSlider).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();

        }

    }
}
