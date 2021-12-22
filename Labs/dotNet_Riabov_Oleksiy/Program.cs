using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DataStud());
            var array = new DataStud[5];
            array[0] = new DataStud();
            array[1] = new DataStud("Vadim", "Petrov", "Kuzmichev");
            array[2] = new DataStud("Maksim", "Petrov", "Kuzmichev");
            array[3] = new DataStud("Kiril", "Petrov", "Kuzmichev");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
