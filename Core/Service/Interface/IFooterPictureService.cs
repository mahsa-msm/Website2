using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IFooterPictureService
    {
        Task<List<FooterPicture>> GetAllFooterPicture();
        void Add(FooterPicture footerPicture);
        FooterPicture FindById(int id);
        void Edit(FooterPicture footerPicture);
        void Delete(FooterPicture footerPicture);

    }
}
