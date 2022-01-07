using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    interface ICar
    {
        bool IsMoving();
    }
    internal class Car
    {
        //public variables  
        public string Color;

        //private vaiables  
        private int _speed;

        //Speed - read-only property to return the speed  
        public int Speed
        {
            get { return _speed; }
        }

        //Accelerate - add mph to the speed  
        public void Accelerate(int accelerateBy)
        {
            //Adjust the speed  
            _speed += accelerateBy;
        }

        //IsMoving - is the car moving?  
        public bool IsMoving()
        {
            //Is the car's speed zero?  
            if (Speed == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Constructor  
        public Car()
        {
            //Set the default values  
            Color = "White";
            _speed = 0;
        }

        //Over loaded constructor  
        public Car(string color, int speed)
        {
            Color = color;
            _speed = speed;
        }
        //methods  
        public double calculateMPG(int startMiles, int endMiles, double gallons)
        {
            return (endMiles - startMiles) / gallons;
        }
    }
    internal class SportsCar : Car
    {
        //Constructor  
        public SportsCar()
        {
            //Change the default values  
            Color = "Green";
        }
    }
    class ReflectionDemo
    {
        public static void ExecuteRelection()
        {
            int a = 10;
            int b = a;

            Car c = new Car();
            Type t = c.GetType(); //class object -> Car class
            Console.WriteLine(t.FullName);
            GetTypeProperties(t);
            Console.ReadLine();
        }
        public static void GetTypeProperties(Type t)
        {
            StringBuilder OutputText = new StringBuilder();

            //properties retrieve the strings   
            OutputText.AppendLine("Analysis of type " + t.Name);
            OutputText.AppendLine("Type Name: " + t.Name);
            OutputText.AppendLine("Full Name: " + t.FullName);
            OutputText.AppendLine("Namespace: " + t.Namespace);

            //properties retrieve references          
            Type tBase = t.BaseType;

            if (tBase != null)
            {
                OutputText.AppendLine("Base Type: " + tBase.Name);
            }
            Type tUnderlyingSystem = t.UnderlyingSystemType;
            if (tUnderlyingSystem != null)
            {
                OutputText.AppendLine("UnderlyingSystem Type: " + tUnderlyingSystem.Name);
                //OutputText.AppendLine("UnderlyingSystem Type Assembly: " + tUnderlyingSystem.Assembly);  
            }
            //properties retrieve boolean          
            OutputText.AppendLine("Is Abstract Class: " + t.IsAbstract);
            OutputText.AppendLine("Is an Arry: " + t.IsArray);
            OutputText.AppendLine("Is a Class: " + t.IsClass);
            OutputText.AppendLine("Is a COM Object : " + t.IsCOMObject);

            OutputText.AppendLine("\nPUBLIC MEMBERS:");
            MemberInfo[] Members = t.GetMembers();

            foreach (MemberInfo NextMember in Members)
            {
                OutputText.AppendLine(NextMember.DeclaringType + " " +
                NextMember.MemberType + "  " + NextMember.Name);
            }
            Console.WriteLine(OutputText);

            MethodInfo[] methods = t.GetMethods();
            OutputText = new StringBuilder();
            foreach (MethodInfo nextMethod in methods)
            {
                OutputText.AppendLine(nextMethod.DeclaringType + " " +
                nextMethod.MemberType + "  " + nextMethod.Name);
            }
        }
    }
}
