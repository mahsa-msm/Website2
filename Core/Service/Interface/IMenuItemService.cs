using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IMenuItemService
    {
        Task<List<MenuItem>> GetAllMenuItem();
        void Add(MenuItem menuItem);
        MenuItem FindById(int id);
        void Edit(MenuItem menuItem);
        void Delete(MenuItem menuItem);

    }
}
