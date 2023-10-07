using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            CreateAt = DateTime.Now;
            UserSkills =  new List<UserSkill>();
            WoneProject = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreateAt { get; private set; }
        public bool Active { get; private set; }


        public ICollection<UserSkill> UserSkills {get; private set;}
        public ICollection<Project> WoneProject { get; private set; }
        public ICollection<Project> FreelanceProjects { get; private set; }

    }
}