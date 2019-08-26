//using System;
//using System.Collections;
//namespace Lab1
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Enter a number between 3 and 9: ");
//            int initial = Int32.Parse(Console.ReadLine());
//            if (initial < 3 || initial > 9)
//            {
//                Console.WriteLine("You need to write a number between 3 and 9!");
//            }
//            else
//            {
//                for (int i = 1; i <= initial; i++)
//                {
//                    Console.Write(i + "\t");
//                    for (int j = 2; j <= initial; j++)
//                    {
//                        if (i > 0) Console.Write(i * j + "\t");
//                        else Console.Write(j + "\t");
//                    }
//                    Console.Write("\n");
//                }

//            }
//            Console.Write("Flip on 1) Horizontal, 2) Vertical, 3) Diagonal, 4) To End: ");
//            int choice= 0;
//            try
//            {
//                 choice = Int32.Parse(Console.ReadLine());
//            }
//            catch (Exception e)
//            {
//                Console.Write(e);
//            }

//            if (choice == 1)
//                {
//                    for (int i = initial; i >= 1; i--)
//                    {
//                        Console.Write(i + "\t");
//                        for (int j = initial - (initial - 2); j <= initial; j++)
//                        {
//                            if (i > 0) Console.Write(i * j + "\t");
//                            else Console.Write(j + "\t");
//                        }
//                        Console.Write("\n");
//                    }
//                    for (int i = initial; i >= 1; i--)
//                    {
//                        Console.Write(i + "\t");
//                        for (int j = 2; j <= initial; j++)
//                        {
//                            if (i > 0) Console.Write(i * j + "\t");
//                            else Console.Write(j + "\t");
//                        }
//                        Console.Write("\n");
//                    }
//                }
//                else if (choice == 2)
//                {
//                    for (int i = 1; i <= initial; i++)
//                    {
//                        for (int j = initial; j >= 1; j--)
//                        {
//                            if (i > 0) Console.Write(i * j + "\t");
//                            else Console.Write(j + "\t");
//                        }
//                        Console.Write("\n");
//                    }
//                }
//                else if (choice == 3)
//                { // Diagonal Left and Right are the same
//                    for (int i = initial; i >= 1; i--)
//                    {
//                        for (int j = initial; j >= 1; j--)
//                        {
//                            if (i > 0) Console.Write(i * j + "\t");
//                            else Console.Write(j + "\t");
//                        }
//                        Console.Write("\n");
//                    }
//                }
//                else if (choice == 4)
//                {
//                    Console.WriteLine("Goodbye");
//                }
//                else
//                {
//                    Console.WriteLine("You need to choose an option between 1 and 4");
//                }
//                Console.ReadLine();
           
//        }
//    }
//}