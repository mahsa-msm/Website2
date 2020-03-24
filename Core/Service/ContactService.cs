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
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext _context;
        public ContactService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetContact(int take = 1)
        {
            return await _context.Contacts.Take(take).ToListAsync();
        }
        public void Add(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
        }
        public Contact FindById(int Id)
        {
            return _context.Contacts.Find(Id);
        }
        public void Edit(Contact contact)
        {
            _context.Entry(contact).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Contact contact)
        {
            _context.Entry(contact).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
