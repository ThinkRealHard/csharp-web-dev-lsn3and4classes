using System;

namespace csharp_web_dev_lsn3and4classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher moe = new Teacher("Moe", "Alali", "C#", 5);
            Student allen = new Student("Allen", 1, 80, 4.0);
            Course here = new Course();
            here.Topic = "C#";
            here.Instructor = moe;

            Console.WriteLine(allen);
            Console.WriteLine(here);
        }
    }
}
