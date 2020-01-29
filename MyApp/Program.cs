using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCollections;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList(10);
            list.add("vineel");
            list.add("chamakuri", 1);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.get(1));
            Console.WriteLine(list.get(list.length));
            Console.WriteLine(list.contains("vineel"));
            list.clear();
            Console.WriteLine(list.length);
            Console.ReadLine();
        }
    }
}
