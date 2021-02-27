using System;
namespace Programming_II_2021_01.University
{
    public class Faculty
    {
        Student[] Students = new Student[50];
        int studentCount = 0;

        Course[] Courses = new Course[50];
        int courseCount = 0;

        Allocation[] Allocations = new Allocation[50];
        int allocationCount = 0;


        public void AddStudent(Student student)
        {
            Students[studentCount] = student;
            studentCount++;
        }

        public void AddCourse(Course course)
        {
            Courses[courseCount] = course;
            courseCount++;
        }

        public void AddAllocation(Allocation allocation)
        {
            Allocations[allocationCount] = allocation;
            allocationCount++;
        }

        public int countStudentsByCourse(string courseName)
        {
            int studentsByCourseCount = 0;

            for (int i=0; i < allocationCount; i++)
            {
                if(Allocations[i].Course.Name == courseName)
                {
                    studentsByCourseCount++;
                }
            }

            return studentsByCourseCount;
        }

        //Cantidad total de dinero por concepto de créditos matriculados
        //por estudiantes de estrato inferior a 3
        public float getTotalAmountStudentWithStratumLessThan(int stratum)
        {
            float total = 0;

            for (int i = 0; i < allocationCount; i++)
            {
                if (Allocations[i].Student.Statum < stratum)
                {
                    total = total + Allocations[i].Course.CreditPrice * Allocations[i].Course.AmountOfCredits;
                }
            }

            return total;
        }

    }
}
