namespace ClassVeInterface
{
    // INTERFACE

    interface OrnekInterface // içerisi boş metot ya da propterty tutuculardır
    {
        // interface ler tek başlarına hiç bir şey ifade etmezler

        //void Add()
        //{
            //Console.WriteLine("deneme");
        //}


        //bu şekilde bir metot yazıp çalıştıramam      
        // Çünkü C# OOP bir programlama ve herşeyin bir class a bağlı ya da class üzerinden dönmesi laızm


        void Add(); //bestpracties metot isimlerinin ve interface başı büyük olur
        // Peki bunu nasıl çalıştırıcam 
        //        - Öncelikle yukarıdaki örnekclass ımıza interface i "implement" edelim
    }

}