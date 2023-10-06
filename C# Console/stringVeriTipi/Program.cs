namespace stringVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degiskenMetin = "Metine çeviriyor";
            string ad = "Mert" ;
            string soyad = "Toyy";
            string degiskenBirlesikMetin = ad + " " + soyad;
            degiskenMetin = $"{ad} deneme {soyad}";
            Console.WriteLine(degiskenMetin);
        }
    }
}