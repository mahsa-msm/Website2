using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IBlogSectionService
    {
        Task<List<BlogSection>> GetBlogSection(int take);
        void Add(BlogSection blogSection);
        BlogSection FindById(int id);
        void Edit(BlogSection blogSection);
        void Delete(BlogSection blogSection);
    }
}
