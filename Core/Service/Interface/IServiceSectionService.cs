using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IServiceSectionService
    {
        Task<List<ServiceSection>> GetServiceSection(int take);
        void Add(ServiceSection serviceSection);
        ServiceSection FindById(int id);
        void Edit(ServiceSection serviceSection);
        void Delete(ServiceSection serviceSection);
    }
}
