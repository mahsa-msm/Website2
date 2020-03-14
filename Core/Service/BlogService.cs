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
    public class BlogService : IBlogService
    {
        private readonly WebsiteContext _context;
        public BlogService(WebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetAllBlog(int take = 3)
        {
            return await _context.Blogs.Take(take).ToListAsync();
        }
        public void Add(Blog blog)
        {
            _context.Add(blog);
            _context.SaveChanges();
        }
        public Blog FindById(int Id)
        {
            return _context.Blogs.Find(Id);
        }
        public void Edit(Blog blog)
        {
            _context.Entry(blog).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Blog blog)
        {
            _context.Entry(blog).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
