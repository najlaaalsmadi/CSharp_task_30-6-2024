using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_task_30_6_2024
{
    internal class Program
    {
        /* 1 - Write a function in C# that accept 10 numbers and return sum and average.
      Test Data :
      Input the 10 numbers:
      Number - 1 :2
      Number - 10 :2
      Expected Output :
      The sum of 10 no is : 55
      The Average is : 5.500000*/
        static void Average()
        {
            int num_for = Convert.ToInt32(Console.ReadLine());
            double sum = 0, avg = 0;
            for (int i = 1; i <= num_for; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;

            }
            avg = sum / num_for;
            Console.WriteLine($"The sum of 10 no is" + sum);
            Console.WriteLine("The Average is :" + avg);
        }
        /* 2-	Write a program in C to display the cube of the number up to given an integer.
            Test Data:
            Input number of terms : 5
            Expected Output :
            Number is : 1 and cube of the 1 is :1
            Number is : 2 and cube of the 2 is :8
            Number is : 3 and cube of the 3 is :27
            Number is : 4 and cube of the 4 is :64
            Number is : 5 and cube of the 5 is :125
*/

        static void cube()
        {
            int num_for = Convert.ToInt32(Console.ReadLine());
            double sum = 0, avg;
            Console.WriteLine(num_for);
            for (int i = 0; i < num_for; i++)
            {
                Console.WriteLine("Input number of terms : ");
                int num = Convert.ToInt32(Console.ReadLine());
                int cube = num * num * num;
                Console.WriteLine($"Number is:{num} and cube of the {num} is {cube}");

            }
        }

        /*3-	Write a program in C# return only numbers in the years array greater than 1950.

          const years = [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020]

          function getYears(years)
        {
        }
        */
        static int getYears(int[] years)
        {
            int max = years.Max();
            return max;

        }
        //4-	Create a function that takes the age in years and returns the age in days.
        static int getDays(int age_years)
        {
            int age_day_age=age_years * 365;
            return age_day_age;
        }
       

        static void Main(string[] args)
        {
            Average();
            cube();
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int num_years_range = Convert.ToInt32(Console.ReadLine());
            List<int> yearsList = new List<int>();
            for (int i = 0; i < num_years_range; i++)
            {
                int num_years = Convert.ToInt32(Console.ReadLine());
                yearsList.Add(num_years);

            }
            int[] years = yearsList.ToArray();

            Console.WriteLine($"The maximum year is: {getYears(years)}");
            int num_years_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The age in days: {getDays(num_years_age)}");
            Range ageRange = new Range(18, 60);
            Gender person1Gender = new Gender(GenderType.Male);
            Gender person2Gender = new Gender(GenderType.Female);
            PhoneNumber phone1 = new PhoneNumber("0771234567");
            PhoneNumber phone2 = new PhoneNumber("0782345678");
            PhoneNumber phone3 = new PhoneNumber("0793456789");

            Employees employees = new Employees(ageRange, person1Gender, person2Gender, "Najlaa", "najlaak399@gmail.com", 25, phone1, phone2, phone3);

            Console.WriteLine("Employee information:");
            Console.WriteLine($"Name: {employees.Name}");
            Console.WriteLine($"Email: {employees.EMail}");
            Console.WriteLine($"ID: {employees.ID}");
            Console.WriteLine($"Phone 1: {employees.Phone1.Number}");
            Console.WriteLine($"Phone 2: {employees.Phone2.Number}");
            Console.WriteLine($"Phone 3: {employees.Phone3.Number}");
            int Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age Range: {employees.AgeRange.IsWithinRange(Age)}");
            Console.WriteLine($"Person 1 Gender: {employees.Person1Gender}");
            Console.WriteLine($"Person 2 Gender: {employees.Person2Gender}");
        }
    }
}
