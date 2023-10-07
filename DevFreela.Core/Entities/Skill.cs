using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            Description = description;
            CriatedAt = DateTime.Now;
        }

        public string Description { get; private set; }
        public DateTime CriatedAt { get; private set; }
    }
}