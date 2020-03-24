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
    public class ContactSectionService : IContactSectionService
    {
        private readonly ApplicationDbContext _context;
        public ContactSectionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ContactSection>> GetcontactSection(int take = 1)
        {
            return await _context.ContactSections.Take(take).ToListAsync();
        }
        public void Add(ContactSection contactSection)
        {
            _context.Add(contactSection);
            _context.SaveChanges();
        }
        public ContactSection FindById(int Id)
        {
            return _context.ContactSections.Find(Id);
        }
        public void Edit(ContactSection contactSection)
        {
            _context.Entry(contactSection).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(ContactSection contactSection)
        {
            _context.Entry(contactSection).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
