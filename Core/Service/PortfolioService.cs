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
    public class PortfolioService : IPortfolioService
    {
        private readonly ApplicationDbContext _context;
        public PortfolioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Portfolio>> GetAllPortfolio()
        {
            return await _context.Portfolios.ToListAsync();
        }
        public void Add(Portfolio portfolio)
        {
            _context.Add(portfolio);
            _context.SaveChanges();
        }
        public Portfolio FindById(int Id)
        {
            return _context.Portfolios.Find(Id);
        }
        public void Edit(Portfolio portfolio)
        {
            _context.Entry(portfolio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Portfolio portfolio)
        {
            _context.Entry(portfolio).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
