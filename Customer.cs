using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13
{
    class Customers : IInterface
    {
        public List<string> customers = new List<string>() { "Tom","Mike", "Jime", "Den" };
        
        void IInterface.ShowCustomers()
        {

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(i + "." + customers[i]);
            }
        }
        void IInterface.AddCustomer()
        {
            string newOne;
            Console.WriteLine("Tell the name of the new one");
            newOne = Console.ReadLine();

            customers.Add(newOne);
            Console.WriteLine("New Customer added");

        }
        void IInterface.RemoveCustomer() 
        {
            Console.WriteLine("Give me number of customer that will be remove");
            int numOf = Convert.ToInt32(Console.ReadLine());
            customers.Remove(customers[numOf]);
            Console.WriteLine("Customer remuved");
        }
    }
}
