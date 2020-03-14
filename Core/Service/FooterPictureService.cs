using Core.Service.Interface;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class FooterPictureService : IFooterPictureService
    {
        private readonly WebsiteContext _context;
        public FooterPictureService(WebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<FooterPicture>> GetAllFooterPicture()
        {
            return await _context.FooterPictures.ToListAsync();
        }
        public void Add(FooterPicture footerPicture)
        {
            _context.Add(footerPicture);
            _context.SaveChanges();
        }
        public FooterPicture FindById(int Id)
        {
            return _context.FooterPictures.Find(Id);
        }
        public void Edit(FooterPicture footerPicture)
        {
            _context.Entry(footerPicture).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(FooterPicture footerPicture)
        {
            _context.Entry(footerPicture).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
