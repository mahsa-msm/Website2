using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interface
{
  public  interface ITeamService
    {
        Task<List<Team>> GetAllTeam();
        void Add(Team team);
        Team FindById(int id);
        void Edit(Team team);
        void Delete(Team team);
    }
}
