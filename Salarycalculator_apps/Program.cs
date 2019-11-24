using System;

namespace Salarycalculator_apps
{
    class Program
    {
        static void Main(string[] args)
        {
            int Empid;
            string Name;
            string Position;
            string Categorie;
            double NumberOfOur;
            Console.WriteLine("WELCOME TO SALARY GET");
            Console.WriteLine("Enter your identification number");
            Empid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter your name");
            Name =(Console.ReadLine());
            Console.WriteLine("Enter your position");
            Position =(Console.ReadLine());
            Console.WriteLine("which categorie are you belong in among this:mothly,hourly or one_time_paid");
            Categorie =(Console.ReadLine());
        
            
            var Employee1=new SalaryCalculator( Empid,Name,Position,Categorie);
            if (Categorie=="mothly")
            {
                Console.WriteLine("your net salary: " + SalaryCalculator.CalculateSalary(500000));
            }
            else if(Categorie=="hourly")
            {
                Console.WriteLine("how many hour you did sir?");
                NumberOfOur = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("your Hourly salary:"+SalaryCalculator.CalculateHourly(3000, NumberOfOur));
            }
            else
            {
                Console.WriteLine("your Hourly salary:"+ SalaryCalculator.CalculateDaily(3000));
            }
           
           
        }
    }
}