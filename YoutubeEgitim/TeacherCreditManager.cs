using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeEgitim
{
    class TeacherCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi verildi.");
        }
    }
}
