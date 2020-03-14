using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IServiceService
    {
        Task<List<Services>> GetAllService(int take);
        void Add(Services services);
        Services FindById(int id);
        void Edit(Services services);
        void Delete(Services services);
    }

}
