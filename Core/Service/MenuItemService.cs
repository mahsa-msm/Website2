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
    public class MenuItemService : IMenuItemService
    {
        private readonly WebsiteContext _context;
        public MenuItemService(WebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<MenuItem>> GetAllMenuItem()
        {
            return await _context.MenuItems.ToListAsync();
        }
        public void Add(MenuItem menuItem)
        {
            _context.Add(menuItem);
            _context.SaveChanges();
        }
        public MenuItem FindById(int Id)
        {
            return _context.MenuItems.Find(Id);
        }
        public void Edit(MenuItem menuItem)
        {
            _context.Entry(menuItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(MenuItem menuItem)
        {
            _context.Entry(menuItem).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
