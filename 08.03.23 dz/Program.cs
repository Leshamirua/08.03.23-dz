using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._23_dz
{
    internal class Program
    {
        class Device
        {
            public string Name { get; set; }
            public string Produсer { get; set; }
            public int Value { get; set; }
            public Device() { }
            public Device(string name, string produсer, int value) 
            {
                Name = name;
                Produсer = produсer;
                Value = value;
            }
            public override string ToString() { return Name; }
            public static IEnumerable<Device> GetDifference(Device[] minuend, Device[] subtrahend)
            {
                return minuend.Except(subtrahend);
            }
            public static IEnumerable<Device> GetIntersection(Device[] set1, Device[] set2)
            {
                return set1.Intersect(set2);
            }
            public static IEnumerable<Device> GetUnion(Device[] set1, Device[] set2)
            {
                return set1.Union(set2);
            }

        }
        // разница, пересечение, объеденение
        static void Main(string[] args)
        {
            List<Device> list1 = new List<Device>()
            {
                new Device("Pylesos 1", "Dyson", 2300),
                new Device("Pulesos 2", "Dyson", 2500),
                new Device("Televisor 1", "Samsung", 4000),
                new Device("Televisor 2", "Samsung", 4100),
                new Device("Microvolnovka 1", "Dyson", 1000),
                new Device("Microvolnovka 1", "LG", 1200),
                new Device("Microvolnovka 1", "Samsung", 1100),
                new Device("Chaynic", "LG", 500)
            };
            List<Device> list2 = new List<Device>{
                new Device("Pylesos 1","LG", 2400),
                new Device("Pylesos 2", "Samsung", 2600),
                new Device("Pylesos 3", "Dyson", 2000),
                new Device("Televisor 1", "Dyson", 4500),
                new Device("Televisor 2", "LG", 4200),
                new Device("Microvolnovka 2", "Samsung", 1300),
                new Device("Chaynic", "Samsung", 600)
            };

            //var result = list2.Except(list1);
            //foreach (var s in result)
            //    Console.WriteLine(s);
            //Console.WriteLine('\n');
            List<Device> result = new List<Device>();
            


        }
    }
}
