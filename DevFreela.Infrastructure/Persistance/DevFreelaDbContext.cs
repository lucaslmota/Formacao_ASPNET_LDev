using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistance
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Curso asp net","Só vai .NET",1,1,1000)
            };

            Users = new List<User>
            {
                new User("Lucas Teste","lucas@gmail.com", DateTime.Now)
            };

            Skills = new List<Skill>
            {
                new Skill(".NET")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<UserSkill> UserSkills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}