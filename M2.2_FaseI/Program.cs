using System;

namespace M2._2_FaseI
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nameLetters = { 'j', 'o', 'a', 'q', 'u', 'i', 'n', 'a' };
            for (int i=0; i<=nameLetters.Length;i++)  //Recorrerá el array nameLetters
            {
                Console.WriteLine(nameLetters[i]); //Imprime cada posición del array,la posición se irá incrementando hasta llegar a la ultima letra
                


            }

        }
    }
}
