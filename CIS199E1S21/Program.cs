//Grading ID; R5560
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CIS199E1S21
{
    class Program
    {
        static void Main(string[] args)
        {
            int iHDI;

            WriteLine("What is the Inequality-Adjusted Human Development Index of the country?");
            
            if(int.TryParse(ReadLine(), out iHDI) && (iHDI >= 1 && iHDI <= 100))
                {
                if (iHDI >= 80)
                    WriteLine("The human development level is very high");
                else if (iHDI >= 70)
                    WriteLine("The human development level is high");
                else if (iHDI >= 56)
                    WriteLine("The human development level is medium");
                else
                    WriteLine("The human development level is low");
                }
            else
            {
                WriteLine("Invalid Inequality-Adjusted Human Development Index value (Only 1-100 whole numbers) ");
            }
        }
    }
}
