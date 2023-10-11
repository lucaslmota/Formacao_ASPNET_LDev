using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();
        Task<Project> GetByIdAsync(int id);
        Task AddAsync(Project project);
        Task StartAsync(int id);
        Task AddCommentAsync(ProjectComment projectComment);
        Task SaveChangesAsync();
    }
}