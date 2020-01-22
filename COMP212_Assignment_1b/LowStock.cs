using System;
using System.Collections.Generic;
using System.Text;

namespace COMP212_Assignment_1b
{
    public class LowStock
    {
        //creating class with event-- delegate
        public delegate void CarInventory();
        public event CarInventory carInventory;

        public void SendAlert()
        {
            //creating local variables to keep track of inputs
            int car, soldCar;
            try
            {
                Console.Write("\nHow many cars are in Stock currently  ? " + " ");
                car = int.Parse(Console.ReadLine());
            
              for (int i = 0; i <= car; i++)
                {
                    if (car == 0)
                    {

                        Console.WriteLine("\nOh no.. Your inventory is already low !");
                        break;
                    }

                    else
                    Console.Write("\nHow many cars did you sell ? " + " ");
                    soldCar = int.Parse(Console.ReadLine());
                    if (car < soldCar )
                    {
                        Console.WriteLine("Error.. Please check ! You sold more than inventory ?");
                    }
                    else
                    {
                        car = car - soldCar;
                    }
                }

              if (carInventory != null)
                 carInventory.Invoke();
            }
            catch (Exception)
            {
                Console.WriteLine("\nPlease check your input ! Can only accept integer value");
            }
        }
   }     
}
