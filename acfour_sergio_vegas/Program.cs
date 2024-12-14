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
            int userNumb = 0;
            int sizeArray = 0;
            

            Console.WriteLine(MsgSizeArray);
            sizeArray = GestioError(sizeArray);

            int[] arrayNumb = new int[sizeArray];

            CompleteArray( userNumb, sizeArray, arrayNumb);
            WriteArray(arrayNumb);
        }
        public static int[] CompleteArray(int userNumb, int sizeArray, int[] arrayNumb)
        {           
            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine(MsgUserNumb);
                userNumb = GestioError(userNumb);
                arrayNumb[i] = userNumb;
            }
            return arrayNumb;
        }
        public static void WriteArray(int[] arrayNumb)
        {
            for (int i = 0; i < arrayNumb.Length; i++)
            {
                Console.Write(arrayNumb[i] + " ");
            }
        }
        public static int GestioError( int userNumb)
        {    
            try { userNumb = int.Parse(Console.ReadLine()); }
            catch (FormatException) { Console.WriteLine("Dades introduides incorrectes"); }

            return userNumb;
        }
    }
}