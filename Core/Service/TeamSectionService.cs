using Core.Service.Interface;
using DataLayer.Context;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class TeamSectionService : ITeamSectionService
    {
        private readonly ApplicationDbContext _context;
        public TeamSectionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamSection>> GetTeamSection(int take = 1)
        {
            return await _context.TeamSections.Take(take).ToListAsync();
        }
        public void Add(TeamSection teamTilte)
        {
            _context.Add(teamTilte);
            _context.SaveChanges();
        }
        public TeamSection FindById(int Id)
        {
            return _context.TeamSections.Find(Id);
        }
        public void Edit(TeamSection teamSection)
        {
            _context.Entry(teamSection).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(TeamSection teamSection)
        {
            _context.Entry(teamSection).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
