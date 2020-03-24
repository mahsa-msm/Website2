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
    public class ServiceSectionService : IServiceSectionService
    {
        private readonly ApplicationDbContext _context;
        public ServiceSectionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceSection>> GetServiceSection(int take = 1)
        {
            return await _context.ServiceSections.Take(take).ToListAsync();
        }
        public void Add(ServiceSection serviceSection)
        {
            _context.Add(serviceSection);
            _context.SaveChanges();
        }
        public ServiceSection FindById(int Id)
        {
            return _context.ServiceSections.Find(Id);
        }
        public void Edit(ServiceSection serviceSection)
        {
            _context.Entry(serviceSection).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(ServiceSection serviceSection)
        {
            _context.Entry(serviceSection).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
