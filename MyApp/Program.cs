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
            list.add(2.0);
            list.add("vineel",1);
            list.set(0,"CBIT");
            list.add(true, 3);
            list.add(90f);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.length);
            Console.ReadLine();
        }
    }
}
