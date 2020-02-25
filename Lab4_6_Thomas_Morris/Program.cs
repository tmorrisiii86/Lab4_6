using System;

namespace Lab4_6_Thomas_Morris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Days of the Week Array
            string[] days =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            //Tasks Array
            string[] tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Type in a new task for " + days[i]);
                tasks[i] = days[i] + " : " + Console.ReadLine();
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
