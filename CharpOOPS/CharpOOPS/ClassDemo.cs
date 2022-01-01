using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpOOPS
{
    //static class,partial class,abstract class,sealed class

    static class Product
    {
        public static int GetProductPrice()
        {
            return 0;
        }


    }
    class ClassDemo
    {
        public void data()
        {
            //Sales salesObj = new Sales();
            //salesObj.
            int result = Product.GetProductPrice();
            SalesBangalore salesB = new SalesBangalore();
            salesB.BangaloreCity();
            salesB.SalesReport();
            salesB.SalesTypes();
            SalesChennai salesc = new SalesChennai();
            salesc.ChennaiCity();
            SalesHyderabad salesh = new SalesHyderabad();
            salesh.HyderabadCity();
           // sales salesObj = new sales();
        }
    }

    abstract class sales
    {
        public void SalesTypes()
        {
            Console.WriteLine("welcome");
        }
        public abstract void SalesReport();
    }

    class SalesBangalore:sales
    {
        public override void SalesReport()
        {

        }
        public void BangaloreCity() { }
    }
    class SalesChennai:sales
    {
        public override void SalesReport()
        {
            
        }
        public void ChennaiCity() { }
    }
    class SalesHyderabad
    {
        public void HyderabadCity() { }
    }
}
