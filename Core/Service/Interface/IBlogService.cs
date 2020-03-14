using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAllBlog(int take);
        void Add(Blog blog);
        Blog FindById(int id);
        void Edit(Blog blog);
        void Delete(Blog blog);
    }
}
