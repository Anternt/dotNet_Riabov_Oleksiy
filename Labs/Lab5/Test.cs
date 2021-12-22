using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace Lab5
{
    class Test
    {
       /* static void Main(string[] args)
        {
            TestAverageAge();
            TestAverageAcademicPreformance();
            TestSave();
        }*/

        static void TestAverageAge()
        {
            var collection = new MyCollection<DataStudLab4>();
            var menu = new MyMenu(collection);
            collection.Add(new DataStudLab4("Vadim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Maksim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Kiril", "Petrov", "Kuzmichev", new DateTime(1953, 12, 1), new DateTime(2020, 12, 1), "119a", 123, 63.1f, "KIT"));
            Console.WriteLine($"Test 1: {menu.AverageAge(a) == 35f}");
        }

        static void TestAverageAcademicPreformance()
        {
            var collection = new MyCollection<DataStudLab4>();
            var menu = new MyMenu(collection);
            collection.Add(new DataStudLab4("Vadim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Maksim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Kiril", "Petrov", "Kuzmichev", new DateTime(1955, 12, 1), new DateTime(2020, 12, 1), "119a", 123, 63.1f, "KIT"));
            Console.WriteLine($"Test 2: {menu.AverageAcademicPreformance(a) == 77.9f}");
        }

        static void TestSave()
        {
            var collection = new MyCollection<DataStudLab4>();
            collection.Add(new DataStudLab4("Vadim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Maksim", "Petrov", "Kuzmichev"));
            collection.Add(new DataStudLab4("Kiril", "Petrov", "Kuzmichev", new DateTime(1955, 12, 1), new DateTime(2020, 12, 1), "119a", 123, 63.1f, "KIT"));
            var serializer = new Lab3.MySerializer<DataStudLab4>();
            serializer.Serialization(collection,"TestSave");
            var save = new MyCollection<DataStudLab4>();
            serializer.Deserialization(save, "TestSave");
            for(var i = 0; i < collection.Size; i++)
            {
                if (!collection[i].Equals(save[i]))
                {
                    Console.WriteLine("Test 3: false");
                    return;
                }
            }
            Console.WriteLine("Test 3: true");

        }

        static bool a(DataStudLab4 b)
        {
            if (b.Surname.CompareTo("Petrov") == 0)
            {
                return true;
            }
            return false;
        }
    }
}
