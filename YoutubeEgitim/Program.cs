using System;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Customer(),new MilitaryCreditManager());
            customerManager.GiveCredit();

            Console.ReadKey();
        }
    }
}
