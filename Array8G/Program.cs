using System;

namespace Array8G
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int[] myArray = new int[64];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;

            }

            foreach (var i in myArray)
            {
                Console.WriteLine(myArray[i]);
            }

        }
      
    }
}
