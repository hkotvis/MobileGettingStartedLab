//using System;
//using System.Collections;
// // Uncomment this and comment out other Program.cs to run this one
//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public int Id { get; set; }
//    public enum Program { ComputerScience, Marketing, Nursing, Accounting }
//    public class Student : Person
//    {
//        public int CreditsEarned { get; set; }
//    }

//    public class Teacher : Person
//    {
//        public int YearsTeaching { get; set; }
//    }

//}


//public class Example
//{
//    public static void Main(string[] args)
//    {
//        Person person = new Person();
//        ArrayList studentAL = new ArrayList();
//        ArrayList teacherAL = new ArrayList();
//        var student = new Person.Student();
//        var teacher = new Person.Teacher();
//        int choice = 0;
//        while (choice != 3)
//        {
//            Console.Write("Please enter a:  1) Student, 2) Teacher, 3) End: ");
//            try
//            {
//                choice = Int32.Parse(Console.ReadLine());
//            }
//            catch (Exception e)
//            {
//                Console.Write(e);
//            }

//            if (choice == 1)
//            {            
//                Console.Write("Name: ");
//                student.Name = Console.ReadLine();
                
//                Console.Write("Age: ");
//                student.Age = Int32.Parse(Console.ReadLine());
//                Console.Write("Student ID: ");
//                student.Id = Int32.Parse(Console.ReadLine());
//                Console.Write("Program- 1) Computer Science, 2) Marketing, 3) Nursing, 4) Accounting: ");
//                int inputProgram = Int32.Parse(Console.ReadLine());
//                Console.Write("Credits Earned: ");
//                student.CreditsEarned = (Int32.Parse(Console.ReadLine()));

//                studentAL.Add(student.Name);
//                studentAL.Add(student.Age);
//                studentAL.Add(student.Id);
//                if (inputProgram == 1)
//                {
//                    studentAL.Add(Person.Program.ComputerScience);
//                }
//                else if (inputProgram == 2)
//                {
//                    studentAL.Add(Person.Program.Marketing);
//                }
//                else if (inputProgram == 3)
//                {
//                    studentAL.Add(Person.Program.Nursing);
//                }
//                else if (inputProgram == 4)
//                {
//                    studentAL.Add(Person.Program.Accounting);
//                }
//                studentAL.Add(student.CreditsEarned);
//            }
//            else if (choice == 2)
//            {
//                Console.Write("Name: ");
//                teacher.Name = Console.ReadLine();
//                Console.Write("Age: ");
//                teacher.Age = Int32.Parse(Console.ReadLine());
//                Console.Write("Faculty ID: ");
//                teacher.Id = Int32.Parse(Console.ReadLine());
//                Console.Write("Program- 1) Computer Science, 2) Marketing, 3) Nursing, 4) Accounting: ");
//                int inputProgram = Int32.Parse(Console.ReadLine());
//                Console.Write("Years of Service: ");
//                teacher.YearsTeaching = (Int32.Parse(Console.ReadLine()));

//                teacherAL.Add(teacher.Name);
//                teacherAL.Add(teacher.Age);
//                teacherAL.Add(teacher.Id);
//                if (inputProgram == 1)
//                {
//                    teacherAL.Add(Person.Program.ComputerScience);
//                }
//                else if (inputProgram == 2)
//                {
//                    teacherAL.Add(Person.Program.Marketing);
//                }
//                else if (inputProgram == 3)
//                {
//                    teacherAL.Add(Person.Program.Nursing);
//                }
//                else if (inputProgram == 4)
//                {
//                    teacherAL.Add(Person.Program.Accounting);
//                }
//                teacherAL.Add(teacher.YearsTeaching);

//            }
//        }

//        foreach (Object obj in studentAL) {
//            Console.Write("   {0}", obj );
//        }           
//        Console.WriteLine();
//        foreach (Object obj in teacherAL)
//        {
//            Console.Write("   {0}", obj);
//        }
//        Console.ReadLine();


       
//    }
//}