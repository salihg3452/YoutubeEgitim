using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeEgitim
{
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı.");
        }
        public int Id { get; set; }
        public string City { get; set; }
    }
}
