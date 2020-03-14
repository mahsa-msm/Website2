using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IBanerSliderService
    {
        Task<List<BanerSlider>> GetAllBanerSlider();
        void Add(BanerSlider banerSlider);
        BanerSlider FindById(int id);
        void Edit(BanerSlider banerSlider);
        void Delete(BanerSlider banerSlider);
    }
}
