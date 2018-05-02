using ExpectedObjects;
using Xunit;

namespace OnlineCourse.DomainTest.Curso
{
    public class CursoTest
    {
        [Fact]
        public void HasCreateCourse()
        {
            var expectedCourse = new
            {
                Name = "Angular Course",
                Workload = (double) 40,
                TargetPublic = TargetPublic.Student,
                Price = (double) 100.10
            };

            var course = new Course(expectedCourse.Name, expectedCourse.Workload, expectedCourse.TargetPublic, expectedCourse.Price);

            expectedCourse.ToExpectedObject().ShouldMatch(course);
        }
    }

    public enum TargetPublic
    {
        Student,
        Academic,
        Employee,
        Entrepreneur
    }

    public class Course
    {
        public string Name { get; private set; }
        public double Workload { get; private set; }
        public TargetPublic TargetPublic { get; private set; }
        public double Price { get; private set; }

        public Course(string name, double workload, TargetPublic targetPublic, double price)
        {
            this.Name = name;
            this.Workload = workload;
            this.TargetPublic = targetPublic;
            this.Price = price;
        }
    }
}