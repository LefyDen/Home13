using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13
{
    class Products : IInterface
    {
        List<string> products = new List<string>() { "Pakage of  Milk - 16 $", "Bread - 6$", "Cookies - 34$"};
        public string bayer;
        public string item;
        void IInterface.SellProduct() 
        {
            Console.WriteLine("Give me id(number) of customer");
            int IdOfCustomer = Convert.ToInt32(Console.ReadLine());
            Customers customer = new Customers();
            bayer= customer.customers[IdOfCustomer];

            Console.WriteLine("Give me id(number) of Product");
            int IdOfProduct = Convert.ToInt32(Console.ReadLine());
            Customers product = new Customers();
             item= products[IdOfCustomer];


        }
        void IInterface.AddProduct() 
        {
            string newOne;
            Console.WriteLine("Tell the name of the new oneь and price ");
            newOne = Console.ReadLine();

            products.Add(newOne);
            Console.WriteLine("New Customer added");

        }

        void IInterface.ShowProducts()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(i + "." + products[i]);
            }

        }            
            List<string> AllChecks = new List<string>();
            
            void IInterface.ShowCheck()
            {
                Console.WriteLine("Check of"  + bayer + ":");
                Console.WriteLine("\n Item: " + item);
                AllChecks.Add(bayer + item);
            }

        
    }
}
