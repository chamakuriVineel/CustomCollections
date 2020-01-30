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
            list.add(1.0);
            list.add(1.0, 1);
            list.add("vineel");
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Equals(list.get(1),list.get(3)));
            Console.Read();
            //Console.WriteLine(list.ToString());
            //Console.WriteLine(list.get(1));
            //Console.WriteLine(list.get(list.length));
            //Console.WriteLine(list.contains("vineel"));
            //list.clear();
            //Console.WriteLine(list.length);
            //Console.ReadLine();
        }
    }
}
