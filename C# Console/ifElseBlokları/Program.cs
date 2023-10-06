using System.Threading.Channels;

namespace ifElseBlokları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool degisken1 = false;

            //if (degisken1  == false) 
            //{
            //    Console.WriteLine("degisken değeri false");
            //}

            //bool degisken1 = true;

            //if (degisken1 != false) 
            //{
            //    Console.WriteLine("degisken 1 false değil ; true ");
            //}

            int sayi1 = 11;
            int sayi2 = 12;
            int sayi3 = 13; 
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"{sayi1} değeri {sayi2} dan büyük");
            //}
            //else if (sayi1 < sayi2)
            //{

            //    Console.WriteLine($"{sayi1} değeri {sayi2} dan küçük");
            //    if (sayi3 > sayi1 && sayi3 > sayi1)
            //    {
            //        Console.WriteLine($"{sayi3} değeri, {sayi1} değeri ve {sayi2} değerinden büyüktür");
            //        if ( (sayi3>10 || sayi2 >100) && sayi2 >= 2 )
            //        {
            //            Console.WriteLine("or u da test ettik ve && ile harmanladık");

            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi1} değeri ile  {sayi2} değeri eşit");
            //}


            // ALTERNATİF 1 : --------
            // Eğer tek bir sorgu yapacaksak yani iç içe değil de eğer değer 6 ise şunu yap gibi direk işleme geçiceksek

            //if (sayi1 < sayi2) Console.WriteLine("sayi 1 sayi 2 den küçük");


            // ALTERNATİF 2 : ------- Single if line : bir sonuç döndürür ve sonucu bir yere almamız gerekir

            var result = ((sayi1 > 10 && sayi2 > 10) || sayi3 == 0) ? "Sayi1 10dan büyük" : "Sayi 1 10 dan büyük değil"  ;
            Console.WriteLine(result);

            




        }
    }
}