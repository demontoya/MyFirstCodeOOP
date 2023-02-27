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
                    Id = 100,
                    FirstName = "Maria",
                    LastName = "Posada",
                    BirthDate = new Date(1950, 2, 5),
                    HiringDate = new Date(2022, 12, 12),
                    IsActive = true,
                    Salary = 2000000.34M
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