public class Resume
{
   public string _name = "";

   public List<Job> _jobs = new List<Job>();

   public Resume()
   {

   }

   public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // Console.WriteLine($"{_jobs}");
        for(int i=0;i<_jobs.Count;i++)
            {
                _jobs[i].DisplayJobDetails();
            }
    }
}