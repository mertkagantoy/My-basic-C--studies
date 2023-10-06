namespace switchCase_Bloglari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if else in alternatifi

            //bool degisken = false;


            //switch (degisken)
            // {
            //     case false: // false ise
            //         Console.WriteLine("degisken false");
            //         break;

            //     case true:    // true ise
            //         Console.WriteLine("degisken true");
            //         break;

            //     default:  // ikisi de değilse
            //         Console.WriteLine("degisken ne true ne de alse");
            //         break;
            // }
            int degisken = 16;
            switch (degisken)
            {
                case 15: // false ise
                    Console.WriteLine("degisken 15");
                    break;

                case 10:    // true ise
                    Console.WriteLine("degisken 10");
                    break;

                default:  // ikisi de değilse
                    Console.WriteLine("degişken ne 10 ne de 15");
                    break;
            }




        }
    }
}