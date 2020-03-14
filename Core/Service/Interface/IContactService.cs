using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IContactService
    {
        Task<List<Contact>> GetContact(int take);
        void Add(Contact contact);
        Contact FindById(int id);
        void Edit(Contact contact);
        void Delete(Contact contact);

    }
}
