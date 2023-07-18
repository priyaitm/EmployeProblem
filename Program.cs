using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
          
        {
            int FULL_TIME = 1;
           // int FULL_TIME = 2;
            int PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            Random empCheck = new Random();

            //Console.WriteLine(empCheck.Next(0,2));
            
            EmpWage    employeeWageObj = new EmpWage();

           //  employeeWageObj.CheckPresentAbscentUC1(FULL_TIME, empCheck.Next(0,2));

            employeeWageObj.CalculateEmpWageUC2(FULL_TIME, empCheck.Next(0,2), EMP_RATE_PER_HOUR);

           // employeeWageObj.AddPartTimeEmpWageUC3(FULL_TIME, empCheck.Next(0, 3), EMP_RATE_PER_HOUR, PART_TIME);



            Console.ReadLine();
        }
    }
}
