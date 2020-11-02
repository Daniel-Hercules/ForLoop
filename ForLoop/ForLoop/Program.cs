using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //For is a more controlled alternative to the while loop
            for (int j = 0; j < 5; j++) {
                for(int k = 0; k < 3; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            //foreach allows us to iterate over a collection
            int[] ages = {19, 20, 30, 40 , 50};

            foreach(int age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
