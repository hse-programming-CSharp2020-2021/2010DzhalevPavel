using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[5]; //reference,0 
            string[] b = new string[5]; //null
            
            int[] n1 = new int[5] {1,2,3,4,5};
            int[] n2 = new int[] {1,2,3,4,5};
            int[] n3 = new [] {1,2,3,4,5};
            int[] n4 = {1,2,3,4,5};


            for (int i = 0; i < a.Length; i++)
            {
                n2[i] *= 10;
                Console.WriteLine(n2[i]);
            }
        }
    }
}