using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsTricks.SampleClass;

namespace TipsTricks.Casting
{
    public class CastCompare
    {
        static CastCompare()
        { }

        public static void CompareTest()
        {
            object obj = 1;
            dynamic dyn = "this is dynamic";
            var vr = "this is a var";

            string str = obj.ToString();
            string str2 = dyn;
            string strvr = vr;
            {
                //-----------------------

                object customerObj = new Customer() { Age = 12, Name = "Victor H" };
                dynamic customerDyn = new Customer() { Age = 12, Name = "Victor H" };
                var customerVar = new Customer() { Age = 12, Name = "Victor H" };

                if (customerObj is Customer) //Validation if it is of that class
                {
                    Customer custFromObj = (Customer)customerObj; //We can cast now, if customerObj is not Customer it will raise an exception
                }

                Customer custFromObj2 = customerObj as Customer; //if customerObj is not Customer it will assign NULL to custFromObj2
                if (custFromObj2 != null)
                {
                    //do something
                }
            }
            //-----------------------
            {
                Customer customerObj = new Customer() { Age = 12, Name = "Victor H" };
                object customerObj2 = customerObj;
                Customer customerObj3 = new Customer() { Age = 12, Name = "Victor H" };
                if (customerObj2 == customerObj)
                {
                    Console.WriteLine("Equals");
                }
                if (customerObj == customerObj3)
                {
                }
                else
                {
                    Console.WriteLine("Different because are different objects even if values are exactly the same");
                }
                if (customerObj.Equals(customerObj3))
                {
                    Console.WriteLine("Equals because it evaluates values only");
                }
            }
        }
    }
}
