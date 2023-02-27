using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("OOP CONCEPTS \n\t " +
                    "****************************");

                Console.WriteLine("Please put your year:");
                var year = Console.ReadLine();

                Console.WriteLine("\n\t Please put your month:");
                var month = Console.ReadLine();

                Console.WriteLine("\n\t Please put your day:");
                var day = Console.ReadLine();

                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));

                Console.WriteLine("++++++++++++TESTING LASTET IMPLEMENTATION+++++++++++++++++++");
                

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    IsActive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine())
                };

                Console.WriteLine(salaryEmployee);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}