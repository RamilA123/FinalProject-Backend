﻿using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Services
{
    public class TeamFarmerService : ITeamFarmerService
    {
        private readonly AppDbContext _context;

        public TeamFarmerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamFarmer>> GetAllWithIncludesAsync()
        {
            return await _context.TeamFarmers.Include(m => m.Position).Include(m => m.TeamFarmerSocialMedias).ToListAsync();
        }

        public async Task<TeamFarmerHeader> GetTeamFarmerHeaderDatasAsync()
        {
            return await _context.TeamFarmerHeaders.FirstOrDefaultAsync();
        }

        public async Task<List<TeamFarmerSocialMedia>> GetTeamFarmerSocialMediaDatasAsync()
        {
            return await _context.TeamFarmerSocialMedias.Include(m => m.SocialMedia).ToListAsync();
        }
    }
}
