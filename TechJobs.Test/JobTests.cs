
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
      
        [TestMethod]

        public void TestSettingJobId() {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id - job2.Id == -1 );
        }

        public void TestJobConstructorSetsAllFields() {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName);
            Assert.AreEqual("Desert", job3.EmployerLocation);
            Assert.AreEqual("Quality control", job3.JobType);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency);
        }

        public void TestJobsForEquality() {
            Assert.AreEqual(job3, job4);
        }
    }
}

