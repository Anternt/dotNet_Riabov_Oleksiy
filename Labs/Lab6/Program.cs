using System;
using System.Linq;
using Lab5;
using Lab4;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyCollection<DataStudLab4>();
            collection.Add(new DataStudLab4() { Name = "Leny" });
            collection.Add(new DataStudLab4() { Name = "Dimas", Birthday = new DateTime(2001, 6, 3) });
            collection.Add(new DataStudLab4() { Name = "Vadim", Birthday = new DateTime(2002, 3, 4) });
            collection.Add(new DataStudLab4() { Name = "Ivan" });
            collection.Add(new DataStudLab4() { Name = "Aleksey" });
            collection.Add(new DataStudLab4() { Name = "Danil", Birthday = new DateTime(2002, 10, 5) });
            var result1 = (from DataStudLab4 t in collection
                          where t.Name.ToUpper().StartsWith("D")
                          select t).Min<DataStudLab4>(t => t.Course);
            Console.WriteLine(result1);
        }
    }
}
