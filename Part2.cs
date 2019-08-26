using System;

public class Person
{
    private string name;
    private int age;
    private int id;
    private enum Program { }
    public class Student : Person
    {
        public int creditsEarned;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string inputName)
        {
            this.name = inputName;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int inputAge)
        {
            this.age = inputAge;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int inputId)
        {
            this.id = inputId;
        }
        public int GetCredits()
        {
            return this.creditsEarned;
        }
        public void SetCredits(int inputCredits)
        {
            this.creditsEarned = inputCredits;
        }
    }


    public class Teacher : Person
    {
        public int yearsTeaching;
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string inputName)
        {
            this.name = inputName;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int inputAge)
        {
            this.age = inputAge;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int inputId)
        {
            this.id = inputId;
        }
        public int GetYears()
        {
            return this.yearsTeaching;
        }
        public void SetYears(int inputYears)
        {
            this.yearsTeaching = inputYears;
        }
    }

}



public class Example
{
    public static void Main(string[] args)
    {
        int choice = 0;
        var student = new Person.Student();
        var teacher = new Person.Teacher();
        while (choice != 3)
        {
            Console.Write("Please enter a:  1) Student, 2) Teacher, 3) End: ");
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            if (choice == 1)
            {
                Console.Write("Name: ");
                student.SetName(Console.ReadLine());
                Console.Write("Age: ");
                student.SetAge(Int32.Parse(Console.ReadLine()));
                Console.Write("Student ID: ");
                student.SetId(Int32.Parse(Console.ReadLine()));
                Console.Write("Program: ");
                // student.SetName(Console.ReadLine());
                Console.Write("Credits Earned: ");
                student.SetCredits(Int32.Parse(Console.ReadLine()));

            }
            else if (choice == 2)
            {
                Console.Write("Name: ");
                teacher.SetName(Console.ReadLine());
                Console.Write("Age: ");
                teacher.SetAge(Int32.Parse(Console.ReadLine()));
                Console.Write("Faculty ID: ");
                teacher.SetId(Int32.Parse(Console.ReadLine()));
                Console.Write("Program: ");
                // student.SetName(Console.ReadLine());
                Console.Write("Years of Service: ");
                teacher.SetYears(Int32.Parse(Console.ReadLine()));

            }
        }

         Console.WriteLine(student.GetName() + " " + student.GetAge() + " " + student.GetId());
        Console.WriteLine(teacher.GetName() + " " + teacher.GetAge() + " " + teacher.GetId());
        Console.ReadLine();


        var b = new Person.Teacher();
        Console.WriteLine(b.GetAge());
    }
}