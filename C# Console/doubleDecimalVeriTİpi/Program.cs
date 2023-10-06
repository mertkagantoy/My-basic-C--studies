namespace doubleDecimalVeriTİpi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // double- decimal ondalıklı ve tam sayıları tutar
            // double 2 haneli ondalıklı sayıları tutabilir
            // decimal 28 haneli ondalıklı sayıları tutabilir

            double sayi1 = 10;
            double sayi2 = 10.10;
            double sayi3 = 10.104364574; // veritabanında 2 haneden sonra yazmaz

            decimal sayi4 = 10;
            decimal sayi5 = 10.10m; // decimalde rakamın sonuna "m" yazılır
            decimal sayi6 = 10.3563546375375m;

            double sayi7 = 10010.1054651;
             

            // sayıyı ayırmak için formatlama yaparım

            string para = string.Format("{0:C}", sayi7);
            // C: currency format : #.##0,00
            // çıktının başındaki ? para formatını bilmediğinden

            decimal sonuc = Convert.ToDecimal(sayi1) + Convert.ToDecimal(sayi5);
            // tipler farklı olduğu için formatlama yaptım
            // double ya da decimallle int çarparken int e formatlama yapılmaya gerek yoktur sonuç decimalse
            // decimal sonuç =  (double + decimal) * int

            // int sonuç alıcaksak formatlama gerekir
            // int sonuc = (double + decimal) * convert.todecimal.intsayi



            Console.WriteLine(sonuc);
        }
    }
}
