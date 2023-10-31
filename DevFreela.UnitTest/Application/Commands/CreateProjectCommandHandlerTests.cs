using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTest.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //Arrange
            var projectRepository = new Mock<IProjectRepository>();

            var creatProjectCommand = new CreateProjectCommand
            {
                Title = "Titulo Teste",
                Description = "Uma descricao daora",
                TotalCost = 50000,
                IdClient = 1,
                IdFreelancer = 2
            };

            var creatProjectCommandHandler = new CreateProjectCommandHandler(projectRepository.Object);
            //Act

            var id = await creatProjectCommandHandler.Handle(creatProjectCommand, new CancellationToken());

            //Assert

            Assert.True(id >= 0);
            projectRepository.Verify(pr => pr.AddAsync(It.IsAny<Project>()), Times.Once);
        }
        
    }
}
