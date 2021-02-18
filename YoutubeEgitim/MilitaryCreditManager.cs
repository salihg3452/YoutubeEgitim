using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeEgitim
{
    class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Askeri kredisi hesaplandı.");
        }
    }
}
