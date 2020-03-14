using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
    public interface ITeamSectionService
    {
        Task<List<TeamSection>> GetTeamSection(int take);
        void Add(TeamSection teamSection0);
        TeamSection FindById(int id);
        void Edit(TeamSection teamSection);
        void Delete(TeamSection teamSection);
    }
}
