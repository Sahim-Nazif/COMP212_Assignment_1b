using System;

namespace COMP212_Assignment_1b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWelcome To COMP 212 INVENTORY EVENT PROGRAM OF NAZIF SAHIM");
            Console.WriteLine("**********************************************************");
            //instantiating delegate
            SendAlert sendAlert = new SendAlert();
            sendAlert.Notify();
            
        }
    }
}
