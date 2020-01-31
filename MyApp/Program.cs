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
            list.add(493);
            list.add(908);
            list.add(207);
            list.add(9001);
            Console.WriteLine("index of 9008 "+list.indexOf(9001));
            Console.WriteLine(list.ToString());
            try
            {
                Console.WriteLine(list.sort());
                Console.WriteLine(list.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            list.removeLast();
            list.remove(1);
            list.remove(0);
            Console.WriteLine("index of 9008 " + list.indexOf(9001));
            Console.ReadLine();
        }
    }
}
