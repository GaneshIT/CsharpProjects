using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    /*
     * a delegate holds a reference to a method and also to the 
     * target object on which the method should be called
     * C# delegates are type safe
     * You can pass methods as parameters to a delegate to allow 
     * the delegate to point to the method
     * Delegates are used to define callback methods and implement
     * event handling
     */
    class DBConnection
    {
        public DBConnection(string name)
        {
            this.name = name;
        }
        protected string Name;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
    }

   class DBManager
    {
        public delegate void EnumConnectionsCallback(DBConnection connection);

        static DBConnection[] activeConnections;
        public void AddConnections()
        {
            activeConnections = new DBConnection[5];
            for (int i = 0; i < 5; i++)
            {
                //DBConnection obj = new DBConnection("DBConnection " + (i + 1));
                activeConnections[i] = 
  new DBConnection("DBConnection " + (i + 1));
            }
        }
        public static void EnumConnections(EnumConnectionsCallback callback)
        {
            foreach (DBConnection connection in activeConnections)
            {
                callback(connection);//function call
            }           
        }
    }
    class Delegate1App
    {
        public static void ActiveConnectionsCallback(DBConnection connection)
        {
            Console.WriteLine("Callback method called for "
                              + connection.name);
        }
        //public static void Main()
        //{
        //    DBManager dbMgr = new DBManager();
        //    dbMgr.AddConnections();
        //    //creating delegate obj and passing method reference to it
        //    DBManager.EnumConnectionsCallback myCallback =
        //    new DBManager.EnumConnectionsCallback(ActiveConnectionsCallback);           
        //    DBManager.EnumConnections(myCallback);
        //}
    }






    public delegate void mydata(int x, string y);
    class DelegateDemo
    {
        public void data(int a,string b)
        {

        }
        public void data(DelegateDemo delegateDemo)
        {
            DelegateDemo obj1 = new DelegateDemo();
            mydata mydataObj = new mydata(obj1.data);
            mydataObj(10, "G");
        }
        public void data(DelegateDemo[] delegateDemo)
        {

        }
    }
}
