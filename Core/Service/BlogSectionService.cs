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

    public class BlogSectionService : IBlogSectionService
    {
        private readonly WebsiteContext _context;
        public BlogSectionService(WebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<BlogSection>> GetBlogSection(int take = 1)
        {
            return await _context.BlogSections.Take(take).ToListAsync();
        }
        public void Add(BlogSection BlogSection)
        {
            _context.Add(BlogSection);
            _context.SaveChanges();
        }
        public BlogSection FindById(int Id)
        {
            return _context.BlogSections.Find(Id);
        }
        public void Edit(BlogSection BlogSection)
        {
            _context.Entry(BlogSection).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(BlogSection BlogSection)
        {
            _context.Entry(BlogSection).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();

        }
    }
}
