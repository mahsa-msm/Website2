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
    public class PortfolioSectionService : IPortfolioSectionService
    {
        private readonly ApplicationDbContext _context;
        public PortfolioSectionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PortfolioSection>> GetPortfolioSection(int take = 1)
        {
            return await _context.PortfolioSections.Take(take).ToListAsync();
        }
        public void Add(PortfolioSection portfolioSection)
        {
            _context.Add(portfolioSection);
            _context.SaveChanges();
        }
        public PortfolioSection FindById(int Id)
        {
            return _context.PortfolioSections.Find(Id);
        }
        public void Edit(PortfolioSection portfolioSection)
        {
            _context.Entry(portfolioSection).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(PortfolioSection portfolioSection)
        {
            _context.Entry(portfolioSection).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
