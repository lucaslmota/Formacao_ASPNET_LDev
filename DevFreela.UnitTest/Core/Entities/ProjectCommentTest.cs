using DevFreela.Core.Entities;

namespace DevFreela.UnitTest.Core.Entities
{
    public class ProjectCommentTest
    {
        [Fact]
        public void TestProjectComment() 
        {
            var projComment = new ProjectComment("A qui é um comentário", 1, 1);

            //Assert.Null(projComment.Content);

            //int test = 10;
            //Assert.Equal(test, projComment.IdProject);

            //int test2 = 10;
            //Assert.Equal(test2, projComment.IdUser);

        }
    }
}
