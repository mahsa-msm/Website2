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
    public class TeamService : ITeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Team>> GetAllTeam()
        {
            return await _context.Teams.ToListAsync();
        }
        public void Add(Team team)
        {
            _context.Add(team);
            _context.SaveChanges();
        }
        public Team FindById(int Id)
        {
            return _context.Teams.Find(Id);
        }
        public void Edit(Team team)
        {
            _context.Entry(team).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(Team team)
        {
            _context.Entry(team).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

    }
}
