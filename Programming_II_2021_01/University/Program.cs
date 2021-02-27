using System;
namespace Programming_II_2021_01.University
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Faculty faculty = new Faculty();

            Course programming2 = new Course();
            programming2.Name = "Programming II";
            programming2.AmountOfCredits = 2;
            programming2.CreditPrice = 100;
            faculty.AddCourse(programming2);

            Course dataStructures = new Course();
            dataStructures.Name = "Data structures";
            dataStructures.AmountOfCredits = 3;
            dataStructures.CreditPrice = 200;
            faculty.AddCourse(dataStructures);

            Course algorithms = new Course();
            algorithms.Name = "Algorithms";
            algorithms.AmountOfCredits = 2;
            algorithms.CreditPrice = 150;
            faculty.AddCourse(algorithms);

            Student e1 = new Student();
            e1.Id = "01";
            e1.Name = "Pepito";
            e1.Age = 15;
            e1.Statum = 3;
            faculty.AddStudent(e1);


            Student e2 = new Student();
            e2.Id = "02";
            e2.Name = "María";
            e2.Age = 25;
            e2.Statum = 5;
            faculty.AddStudent(e2);

            Student e3 = new Student();
            e3.Id = "03";
            e3.Name = "Carlos";
            e3.Age = 35;
            e3.Statum = 1;
            faculty.AddStudent(e3);

            Student e4 = new Student();
            e4.Id = "04";
            e4.Name = "Carolina";
            e4.Age = 17;
            e4.Statum = 1;
            faculty.AddStudent(e4);

            Student e5 = new Student();
            e5.Id = "05";
            e5.Name = "Natalia";
            e5.Age = 21;
            e5.Statum = 4;
            faculty.AddStudent(e5);


            Allocation a1 = new Allocation();
            a1.Course = programming2;
            a1.Student = e2;
            a1.Shift = 0; //night
            faculty.AddAllocation(a1);
                
            Allocation a2 = new Allocation();
            a2.Course = dataStructures;
            a2.Student = e1;
            a2.Shift = 1; //day
            faculty.AddAllocation(a2);

            Allocation a3 = new Allocation();
            a3.Course = programming2;
            a3.Student = e1;
            a3.Shift = 0; //day
            faculty.AddAllocation(a3);

            Allocation a4 = new Allocation();
            a4.Course = algorithms;
            a4.Student = e3;
            a4.Shift = 1; //day
            faculty.AddAllocation(a4);

            Allocation a5 = new Allocation();
            a5.Course = programming2;
            a5.Student = e4;
            a5.Shift = 1; //day
            faculty.AddAllocation(a5);


            /*
            Console.WriteLine("Enter the course name: ");
            string course = Console.ReadLine();
            int studentsByCourse = faculty.countStudentsByCourse(course);
            Console.WriteLine("Amount of students " + studentsByCourse);
            */

            Console.WriteLine("Enter the strum to filter out results: ");
            string stratumStr = Console.ReadLine();
            int stratum = int.Parse(stratumStr);
            float total = faculty.getTotalAmountStudentWithStratumLessThan(stratum);
            Console.WriteLine("Total amount by students with stratum less than given value: " + total);
        }
    }
}
