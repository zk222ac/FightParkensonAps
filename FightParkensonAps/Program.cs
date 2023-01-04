using FightParkensonAps;
using System;
namespace FlightPerkinsonAps
{
    internal class Program 
    {
      static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            var student = new Student
            {
                Id = Guid.Parse("64fd651d-d7bf-4955-7200-08daed89168e"),
                Name = "Zuhair Haroon"
            };

            var broker = new StorageBroker();
            //broker.Add(student);
            broker.Update(student);
            broker.SaveChanges();          
        }    
    }
}