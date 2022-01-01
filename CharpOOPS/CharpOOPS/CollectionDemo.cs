using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public person(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public List<person> persondetails(List<person> persons)
        {            
            return persons;
        }
    }
    class CollectionDemo
    {
        public void Data()
        {
            //List<person>
            person personobj = new person(1, "Ganesh", 400);
            //Console.WriteLine(personobj.id);
            //Console.WriteLine(personobj.name);
            //Console.WriteLine(personobj.salary);
            // List<>
        }
    }
}
