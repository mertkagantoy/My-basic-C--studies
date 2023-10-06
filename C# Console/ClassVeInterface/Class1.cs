using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVeInterface
{
    internal class Class1 // aynı proje içinde old için internal ile de ulaşırım /public de yazabilirim
        //private ise sace aynı class ta çağırılabilir
        //internal sadece aunı projeden çağırılabilir
    {
        internal void CallClass()
        {
            Console.WriteLine("class çağırıldı");
        }
    }
}
