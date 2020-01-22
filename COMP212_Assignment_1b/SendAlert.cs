using System;
using System.Collections.Generic;
using System.Text;

namespace COMP212_Assignment_1b
{
    //this class will act as subscriber to the LowStock class
    public class SendAlert
    {
        private LowStock lowStock;

        //creating constructor
        public SendAlert()
        {
            lowStock = new LowStock();
            lowStock.carInventory += LowStock_carInventory;
        }

       public void LowStock_carInventory()
        {
            Console.WriteLine("\nThe Inventory is getting low. Please order more car !");
            Console.ReadKey();
        }

        public void Notify()
        {
            lowStock.SendAlert();
        }
    }
}
