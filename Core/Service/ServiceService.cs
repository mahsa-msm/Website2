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
    public class ServiceService : IServiceService
    {
        private readonly WebsiteContext _context;
        public ServiceService(WebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Services>> GetAllService(int take = 5)
        {
            return await _context.Services.Take(take).ToListAsync();
        }
        public void Add(Services services)
        {
            _context.Add(services);
            _context.SaveChanges();
        }
        public Services FindById(int Id)
        {
            return _context.Services.Find(Id);
        }
        public void Edit(Services services)
        {
            _context.Entry(services).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Services services)
        {
            _context.Entry(services).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}

