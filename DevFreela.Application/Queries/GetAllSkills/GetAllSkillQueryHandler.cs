using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillQueryHandler : IRequestHandler<GetAllSkillQuery, List<SkillDTO>>
    {
        private readonly IIskillRepository _iskillRepository;

        public GetAllSkillQueryHandler(IIskillRepository iskillRepository)
        {
            _iskillRepository = iskillRepository;
        }
        public async Task<List<SkillDTO>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
        {
            return await _iskillRepository.GetAllAsync();
        }
    }
}