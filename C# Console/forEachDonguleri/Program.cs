using System.Collections.Generic;

namespace forEachDonguleri
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> list = new List<string>();
            list.Add("domates");
            list.Add("patetes");
            list.Add("patlıcan");

            Console.WriteLine($"listenin eleman sayısı {list.Count}");
            // FOR DÖNGÜSÜ
            //for (int i = 0; i < list.Count; i++) 
            //{
            //    Console.WriteLine(list[i]);
            //}

            //foreach derki sen bana listeyi ver ben o listediki her bir eleman için sana bir geri dönüş yapayım

            foreach (var item in list) 
            { 
                Console.WriteLine(item); 
            }
             // foreach for döngüsüne göre daha çok kullanılır

            
        }
    }
}