using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface IPortfolioSectionService
    {
        Task<List<PortfolioSection>> GetPortfolioSection(int take);
        void Add(PortfolioSection portfolioSection);
        PortfolioSection FindById(int id);
        void Edit(PortfolioSection portfolioSection);
        void Delete(PortfolioSection portfolioSection);
    }
}
