using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Core.DTOs;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistance.Repositpries
{
    public class IskillRepository : IIskillRepository
    {
        private readonly DevFreelaDbContext _devFreelaDbContext;
        public IskillRepository(DevFreelaDbContext devFreelaDbContext)
        {
            _devFreelaDbContext = devFreelaDbContext;
        }
        public async Task<List<SkillDTO>> GetAllAsync()
        {
            var script = "SELECT Id, Description FROM Skills";

            var skill = await _devFreelaDbContext.Database.GetDbConnection().QueryAsync<SkillDTO>(script);

            return skill.ToList();
        }
    }
}