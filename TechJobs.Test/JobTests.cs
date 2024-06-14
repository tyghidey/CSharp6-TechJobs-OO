
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job5 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
      
        [TestMethod]

        public void TestSettingJobId() {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id - job2.Id == -1 );
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields() {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality() {
            Assert.AreNotEqual(job3, job4);
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine() {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));

        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData() {
            string newLine = Environment.NewLine;
            Assert.AreEqual(newLine + "ID: " + job3.Id + newLine + "Name: " + job3.Name + newLine + "Employer: " + job3.EmployerName + newLine + "Location: " + job3.EmployerLocation + newLine + "Position Type: " + job3.JobType + newLine + "Core Competency: " + job3.JobCoreCompetency + newLine, job3.ToString());
        // use tests already est. no hard coding
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField() {
            string newLine = Environment.NewLine;
            Assert.AreEqual(newLine + "ID: " + job5.Id + newLine + "Name: Product tester" + newLine + "Employer: Data not available" + newLine + "Location: Desert" + newLine + "Position Type: Quality control"  + newLine + "Core Competency: Persistence" + newLine, job5.ToString());
        }
    }
}