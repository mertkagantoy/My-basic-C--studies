using ClassVeInterface;
using System.Security.Cryptography.X509Certificates;

namespace ClassVeInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OrnekClass ornekClass_1 = new OrnekClass(); // örnek oluşturma ,PARAMETRE YOK 

            //ornekClass_1.Degisken1 = "Deneme Class 1"; // değer atama

            //Console.WriteLine(ornekClass_1.Degisken1);


            // parametreli örnek oluşturma 

            OrnekClass ornekClass_2 = new OrnekClass("mert");


            //Console.WriteLine(ornekClass_2.Degisken1);

            ornekClass_2.Degisken1 = "mert2";

            //Console.WriteLine(ornekClass_2.Degisken1);


            // interface den ornek classa dahil ettiğim metod u main class ta çağıracağım

            ornekClass_2.Add();

            ornekClass_2.Add2();
            ornekClass_2.id = 10; //Id benim mevcut örnek class ım da yoktu ama inherit ile başka classtan çektim
            // Class'a Class dahil etmeye Inherit denir

            ornekClass_2.uptade();

            Class1 _class1 = new Class1();
            _class1.CallClass();





        }

    }





    // C# OOP dil olduğu için C# da çalışan her bir şey bir class a bağlı yada class ın üzerinde çalışır.
    class OrnekClass : DenemeClass, OrnekInterface, OrnekInterface2// interface i class a implement ettik
    {

        // PEKİ PARAMETRE ATAYABİLMEK İÇİN NE YAPMAM LAZIM CONSTRUCTOR


        public OrnekClass(string name) //ctor tab tab
        {
            Degisken1 = name;
        }





        // class üzerinde 
        //Propterty ve Metotlarlar tutabiliyoruz

        //Proptertyler : Bizim değişkenlerin get ve set metotları ile çalışan hali
        public string Degisken1 { get; set; } // bu değişkenin get ve set edilebiliceğini söylüyorum

        // get bloğu değişkene benim dışarıdan oluşup görüntülememi,set bloğu değişkene dışarıdan veri atamamı sağlıyor

        // interface bir metot tutucu olduğu için içindeki metodu buraya dahil etmem gerekiyor

        public void Add() // interface 1 metodu
        {
            Console.WriteLine("Deneme interface metot");
        }

        public void Add2() // interface 2 metodu
        {
            Console.WriteLine("DENEME İNTERFACE2 ");
        }


    }




    class DenemeClass //bu class ı yukarıdaki örnek class a implement edersem örnek class da id değişkeni olur
    {
        public int id { get; set; }

        public void uptade()
        {
            Console.WriteLine("uptade metodu çalıştı");
        }
    }

}