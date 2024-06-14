using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job (string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }
        
            // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
            public override bool Equals(object? obj)
            {
                return obj is Job job &&
                    Id == job.Id;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Id);
            }

            public override string ToString()
            {
                string newLine = Environment.NewLine;
                if (this.Name == "")
                {
                    this.Name = "Data not available";
                }
                if (this.EmployerName.Value == "")
                {
                    this.EmployerName.Value = "Data not available";
                }
                if (this.EmployerLocation.Value == "")
                {
                    this.EmployerLocation.Value = "Data not available";
                }
                if (this.JobType.Value == "")
                {
                    this.JobType.Value = "Data not available";
                }
                if (this.JobCoreCompetency.Value == "")
                {
                    this.JobCoreCompetency.Value = "Data not available";
                }
                return Environment.NewLine + "ID: " + this.Id + newLine + "Name: " + this.Name + newLine + "Employer: " + this.EmployerName + newLine + "Location: " + this.EmployerLocation + newLine + "Position Type: " + this.JobType + newLine + "Core Competency: " + this.JobCoreCompetency + Environment.NewLine;
            }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

    }
}

