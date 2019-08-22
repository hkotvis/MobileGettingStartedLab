using System;
using System.Collections;
namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number between 3 and 9: ");
            int initial = Int32.Parse(Console.ReadLine());
            if(initial < 3 || initial > 9)
            {
                Console.WriteLine("You need to write a number between 3 and 9!");
            }
            else
            {

                
                for (int i = 1; i <= initial; i++)
                {
                    Console.Write(i + " ");
                    if (initial % i == 0) Console.WriteLine();
                }
                    
                    
                
                

                Console.WriteLine();
                for (int j = 1; j <= initial; j++)
                {
                    Console.Write(j + j + " ");
                }
                Console.WriteLine();
                for (int k = 1; k <= initial; k++)
                {
                    Console.Write(k + k + k + " ");
                }
            }
            Console.Write("Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: ");
            if(Int32.Parse(Console.ReadLine()) == 1)
            {

            }
            else if (Int32.Parse(Console.ReadLine()) == 2)
            {

            }
            else if (Int32.Parse(Console.ReadLine()) == 3)
            {

            }
            else if (Int32.Parse(Console.ReadLine()) == 4)
            {

            }
            else
            {

            }


        }
    }
}
