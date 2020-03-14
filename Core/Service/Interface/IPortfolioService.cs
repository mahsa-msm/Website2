using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{

    public interface IPortfolioService
    {
        Task<List<Portfolio>> GetAllPortfolio();
        void Add(Portfolio portfolio);
        Portfolio FindById(int id);
        void Edit(Portfolio portfolio);
        void Delete(Portfolio portfolio);
    }
}
