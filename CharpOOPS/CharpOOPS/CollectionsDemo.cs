using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    //return type and no return type functions
    //return type - int, string, float, class type
    class person
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    class CollectionsDemo
    {
        public List<int> GetAge(int birthYear)
        {
            int readId = 0;
            string readName = string.Empty;
            List<person> perslist = new List<person>();
            for (int i = 0; i < 5; i++)
            {
                readId = Convert.ToInt32(Console.ReadLine());
                readName = Console.ReadLine();
                perslist.Add(new person { id = readId, name = readName });
            }
            //approach 1
            person personobj = new person();
            personobj.id = readId;
            personobj.name = readName;
            perslist.Add(personobj);

            //approach 2
            perslist.Add(new person { id = readId, name = readName });

            //approach 3
            person personobj1 = new person { id = readId, name = readName };
            perslist.Add(personobj1);

            List<int> listdata = new List<int>();
            int age = DateTime.Now.Year - birthYear;
            listdata.Add(age);
            foreach (var item in listdata)
            {
                Console.WriteLine(item);
            }        
            return listdata;
        }
    }

    class Employee
    {
        public void data()
        {
            CollectionsDemo collectionsDemo = new CollectionsDemo();
            collectionsDemo.GetAge(1997);
        }
    }
}
