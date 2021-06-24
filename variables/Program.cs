using System;

namespace variables
{
    class Program
    {

        static void Main(string[] args)
        {
            string name;
            int age;
            float score;
            bool active = false;
            score = 12.5f;
            // age = 69;
            active = true;
            name = "steve";
            Console.WriteLine("Hello " + name);
            string nb = "10"; 
            int res = int.Parse(nb);

            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age = " + age.ToString());
        }
    }
}
