using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeEgitim
{
    interface ICreditManager
    {
        void Calculate();
        void Save();
    }
    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();

        public void Save()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
}
