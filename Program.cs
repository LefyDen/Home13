using System;

namespace Home13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Available actions: \n 1-Show Products \n 2-Add Product \n 3-Show Customers \n 4-Add Customer  \n 5 - Remove Customer \n 6-Buy Product");
                int c = Convert.ToInt32(Console.ReadLine());
                IInterface forSHowProduct = new Customers();
                IInterface forAddProduct = new Products();
                IInterface forShowCustomers = new Products();
                IInterface forAddCustomer = new Customers();
                IInterface forRemoveCustomer = new Customers();
                IInterface forBuy = new Products();
                Check forCheck = new Check();
                if (c == 1)
                {
                    forSHowProduct.ShowProducts();
                }
                else if (c == 2)
                {

                    forAddProduct.AddProduct();
                }
                else if (c == 3)
                {

                    forShowCustomers.ShowCustomers();
                }
                else if (c == 4)
                {
                    forAddCustomer.AddCustomer();
                }
                else if (c == 5)
                {

                    forRemoveCustomer.RemoveCustomer();
                }
                else if (c == 6)
                {
                    forBuy.SellProduct();
                    forBuy.ShowCheck();
                }


            }
        }
    }
    interface IInterface
    {
        void SellProduct() { }
        void ShowProducts() { }
        void AddProduct() { }
        void ShowCustomers() { }
        void AddCustomer() { }
        void RemoveCustomer() { }
        void ShowCheck() { }
    }

}
