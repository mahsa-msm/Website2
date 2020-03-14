using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Core.Service.Interface
{
    public interface IAboutService
    {
        Task<List<About>> GetAllAbout(int take);
        void Add(About about);
        About FindById(int id);
        void Edit(About about);
        void Delete(About about);
    }
}
