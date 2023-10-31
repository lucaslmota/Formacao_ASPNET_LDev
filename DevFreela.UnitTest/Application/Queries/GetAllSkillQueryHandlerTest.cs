using DevFreela.Application.Queries.GetAllSkills;
using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;

namespace DevFreela.UnitTest.Application.Queries
{
    public class GetAllSkillQueryHandlerTest
    {
        [Fact]
        public async Task TestandoSkillRetornandoSkillDTO()
        {
            //Arrange
            var skills = new List<SkillDTO>{};

            var skillRepositoryMock = new Mock<IIskillRepository>();
            skillRepositoryMock.Setup(sk => sk.GetAllAsync().Result).Returns(skills);

            var getAllSkillQuery = new GetAllSkillQuery();
            var getAllSkillQueryHandler = new GetAllSkillQueryHandler(skillRepositoryMock.Object);

            //Act
            var skillDTOList = await getAllSkillQueryHandler.Handle(getAllSkillQuery, new CancellationToken());

            //Assert
            Assert.NotNull(skillDTOList);
            Assert.Equal(skills.Count, skillDTOList.Count);

            skillRepositoryMock.Verify(sk => sk.GetAllAsync().Result, Times.Once);
        }
    }
}
