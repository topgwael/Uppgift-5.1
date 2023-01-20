using System;

namespace Array
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("skriv hur många manm du vill ha");
            int antal = int.Parse(Console.ReadLine());
            string[] namn = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("skriv ett namn");
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("här är namnet du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
