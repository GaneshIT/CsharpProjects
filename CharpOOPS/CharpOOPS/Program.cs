using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Eligible();
        }

        public static void Eligible()
        {
            CollectionsDemo collectionsDemo = new CollectionsDemo();
            List<int> getAgeList = collectionsDemo.GetAge(1997);
            for (int i = 0; i < getAgeList.Count; i++)
            {

            }
            int age =getAgeList[0];
            if (age > 18 && age < 28)
                Console.WriteLine("Class 1 type");
            else if (age > 28 && age < 38)
                Console.WriteLine("Class 2 type");
            else if (age > 38 && age < 28)
                Console.WriteLine("Class 3 type");
        }
    }
}
