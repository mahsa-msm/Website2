
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{

    public interface IContactSectionService
    {
        Task<List<ContactSection>> GetcontactSection(int take);
        void Add(ContactSection contactSection);
        ContactSection FindById(int id);
        void Edit(ContactSection contactSection);
        void Delete(ContactSection contactSection);
    }

}
