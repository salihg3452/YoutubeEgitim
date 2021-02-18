using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeEgitim
{
    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;
        public CustomerManager(Customer customer,ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }
        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi: ");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri silindi: ");
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi.");
        }
    }
}
