
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
            BubbleSort( arrayNumb );
            WriteArray(arrayNumb);
            
        }
        public static void BubbleSort(int[] arrayNumb)
        {
            for (int i = 0; i < arrayNumb.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayNumb.Length; j++)
                {
                    if (arrayNumb[i] > arrayNumb[j])
                    {
                        int aux = arrayNumb[i];

                        arrayNumb[i] = arrayNumb[j];

                        arrayNumb[j] = aux;
                    }
                }
            }
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


