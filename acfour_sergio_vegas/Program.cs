using System;

namespace acfour_sergio_vegas
{
    public static class implementacioDiagrama
    {
        //Constants
        const string MsgSizeArray = "Introdueix el tamany que vols enmagatzemar.";
        const string MsgUserNumb = "Introdueix un numero.";
        public static void Main(String[] args)
        {
            Console.WriteLine(MsgSizeArray);
            int sizeArray = int.Parse(Console.ReadLine());

            int[] arrayNumb = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine(MsgUserNumb);
                int userNumb = int.Parse(Console.ReadLine());
                arrayNumb[i] = userNumb;
            }
            WriteArray(arrayNumb);
        }
        public static void WriteArray(int[] arrayNumb)
        {
            for (int i = 0; i < arrayNumb.Length; i++)
            {
                Console.Write(arrayNumb[i] + " ");
            }
        }
        public static int GestioError()
        {
            int userNumb = 0;
            try { userNumb = int.Parse(Console.ReadLine()); }
            catch (FormatException) { Console.WriteLine("Dades introduides incorrectes"); }

            return userNumb;
        }
    }
}