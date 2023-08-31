using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // declaring variable in snake case 
            int marks_math, marks_phy, marks_cs;
            decimal percentage;

            Console.WriteLine("Please enter the marks that you got in Maths");
            marks_math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the marks that you got in Physics");
            marks_phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the marks that you got in Computer Science");
            marks_cs = Convert.ToInt32(Console.ReadLine());

            percentage = (marks_math + marks_phy + marks_cs)/3;
            Console.WriteLine( "Your percentage is " + percentage );
            // Find the grade of the student,
            //A if score > 90
            //B + if score > 80 but less than or equal to 90
            //B if score > 70 but less than or equal to 80
            //B - if score > 60 but less than or equal to 70
            //C if score >= 50 but less than or equal to 60
            //D  if score less than 50

            if (percentage > 90)
            {
                Console.WriteLine("You got A grade");
            }
            else
            {
                if (percentage > 80 && percentage <= 90)
                {
                    Console.WriteLine("You got B+ grade");
                }
                else
                {
                    if (percentage > 70 && percentage <= 80)
                    {
                        Console.WriteLine("You got B grade");
                    }
                    else
                    {
                        if (percentage > 60 && percentage <= 70)
                        {
                            Console.WriteLine("You got B- grade");
                        }
                        else
                        {
                            if (percentage >= 50 && percentage <= 60)
                            {
                                Console.WriteLine("You got C grade");
                            }
                            else
                            {
                                Console.WriteLine("You got D grade");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
