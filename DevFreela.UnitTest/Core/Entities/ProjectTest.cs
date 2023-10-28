using DevFreela.Core.Entities;
using DevFreela.Core.Enums;

namespace DevFreela.UnitTest.Core.Entities
{
    public class ProjectTest
    {
        [Fact]
        public void TestIfProjectStartWorks()// Testar se o projeto inicia
        {
            var project = new Project("Nome de test", "Descirção de teste",1,2, 1000);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);

            Assert.NotNull(project.Title);
            Assert.NotEmpty(project.Title);

            Assert.NotNull(project.Description);
            Assert.NotEmpty(project.Description);

            project.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);
        }

        [Fact]
        public void CancelarProjetoTeste()
        {
            var project = new Project("Nome de test", "Descirção de teste", 1, 2, 1000);

            project.Cancel();
        }

        [Fact]
        public void EntregarProjetoTeste()
        {
            var projec = new Project("Nome de test", "Descirção de teste", 1, 2, 1000);

            projec.Finish();
        }

        [Fact]
        public void AtualizarProjetoTeste()
        {
            var project = new Project("Nome de test", "Descirção de teste", 1, 2, 1000);

            project.Update(project.Title,project.Description, project.TotalCost);
        }
    }
}
