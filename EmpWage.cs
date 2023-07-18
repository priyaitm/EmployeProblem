using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    internal class EmpWage { 
         
        public void CheckPresentAbscentUC1 (int FULL_TIME , int  empCheck )
            
        {
            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is not  present");
            }

            Console.ReadLine();
        }


        public void CalculateEmpWageUC2(int FULL_TIME, int empCheck, int EMP_RATE_PER_HOUR) {
            int empHrs, empWage;
            

            if(empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("EmpWage: " + empWage);
            Console.ReadLine();

        }
        public void AddPartTimeEmpWageUC3(int FULL_TIME, int empCheck, int EMP_RATE_PER_HOUR, int PART_TIME )
        {
            int empHrs, empWage;
          
            if (empCheck == PART_TIME) { 
                empHrs = 4;
            }

            else if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            
            Console.WriteLine("EmpWage: " + empWage);
            Console.ReadLine();

        }
    }
}
