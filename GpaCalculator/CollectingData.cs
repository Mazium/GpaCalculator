using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpaCalculator
{

   
    internal class CollectingData

    {
        
        int gradeA = 4;
        int gradeB = 3;
        decimal gradeAverage;
        int totalGradePoint = 0;
        int totalCreditHours = 0;
       
        public void SophiaGpa()
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int creditHour1 = 3;
            int creditHour2 = 3;
            int creditHour3 = 4;
            int creditHour4 = 4;
            int creditHour5 = 3;

            int credit1 = 4;
            int credit2 = 3;
            int credit3 = 3;
            int credit4 = 3;
            int credit5 = 4;

            int gP1 = credit1 * creditHour1;
            int gP2 = credit2 * creditHour2;
            int gP3 = credit3 * creditHour3;
            int gP4 = credit4 * creditHour4;
            int gP5 = credit5 * creditHour5;



            int[] totalGp = new int[5] { gP1, gP2, gP3, gP4, gP5 };

            totalGradePoint = totalGp.Sum();

            int[] CreditHours = new int[5] { creditHour1, creditHour2, creditHour3,creditHour4, creditHour5 };
            
            totalCreditHours = CreditHours.Sum();

            decimal gradeAverage = (decimal)totalGradePoint / (decimal)totalCreditHours;






            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\tCredit\t\tCreditHours\tGradePoints\n");

            Console.WriteLine($"{course1Name}\t\t{credit1}\t\t{creditHour1}\t\t{gP1}\n");
            Console.WriteLine($"{course2Name}\t\t{credit2}\t\t{creditHour2}\t\t{gP2}\n");
            Console.WriteLine($"{course3Name}\t\t{credit3}\t\t{creditHour3}\t\t{gP3}\n");
            Console.WriteLine($"{course4Name}\t{credit4}\t\t{creditHour4}\t\t{gP4}\n");
            Console.WriteLine($"{course5Name}\t\t{credit5}\t\t{creditHour5}\t\t{gP5}\n");


            Console.WriteLine($"Final GPA: {Math.Round(gradeAverage, 2)}");
            



        }

       
        
            
        


    }
}
