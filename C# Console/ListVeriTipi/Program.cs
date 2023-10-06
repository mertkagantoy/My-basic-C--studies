using System.Collections.Generic;

namespace ListVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string alisveris1 = "domates";
            string alisveris2 = "patates";
            string alisveris3 = "patlıcan";

            list.Add(alisveris1);
            list.Add(alisveris2);
            list.Add(alisveris3);

            //Console.WriteLine(list[3]);
            List<int> list2 = new List<int>();
            //list2.Add(10);
            list2.Add(Convert.ToInt16("10"));
            list2.Add(20);
            list2.Add(30);

            //Console.WriteLine(list2[0]);

            //alternatif list yapma

            string[] list3 = new string[2];
            // bunun yukarıdakinden farkı bunda içerisine kaç tane eleman koyucağımı belirtmek zorundayım>
            list3[0] = alisveris1;
            list3[1] = alisveris2;
            list3[2] = alisveris3;
            // Console.WriteLine(list3[2] ); index out
        }
    }
}