namespace IntegerVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            sayi1 = 19;
            //uint sayi2; uint 32 bit daha geniş aralığı var 

            int sayi2 = 15;
            uint sayi3 = 25;


            long taksittutari = (10000 / sayi2) * sayi3;
            //işlemde int ve uint karışık olduğu için long yazdım ortak
//eğer int kullanmak istiyorsam = (10000 / sayi2)* Convert.ToInt16(sayi3) = formatlama
            Console.WriteLine(taksittutari);




        }
    }
}