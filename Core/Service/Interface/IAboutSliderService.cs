using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IAboutSliderService
    {
        Task<List<AboutSlider>> GetAllAboutSlider();
        void Add(AboutSlider aboutSlider);
        AboutSlider FindById(int id);
        void Edit(AboutSlider aboutSlider);
        void Delete(AboutSlider aboutSlider);

    }
}
