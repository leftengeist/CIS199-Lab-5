//N5284
//Lab 5
//3/3/2019
//CIS 199-75
//This program prompts user for a temperature between -20 and 130 and gives an average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Dictionary
            const int MIN_TEMP       = -20; //Min temp that can be input by user
            const int MAX_TEMP       = 130; //Max temp that can be input by user
            const int SENTINAL_VALUE = 999; //The value to exit the while loop

            int inputAmount = 0;            //The number of inputs given by the user
            int inputTemp   = 0;            //The temp given by the user

            double totalTemp   = 0;         //The added total of the user inputed temps
            double averageTemp = 0;         //The average value of the temps inputed

            bool validTemp;                 //boolean value to check if the temp is valid


            Console.Write("Enter Temperatures from -20 to 130: ");
            validTemp = Int32.TryParse(Console.ReadLine(), out inputTemp);
            
            //While the input is not the sentinal value stay in the loop
            while(inputTemp != SENTINAL_VALUE)
            {
                //While the temp is invalid stay in the loop
                while (!validTemp || inputTemp < MIN_TEMP || inputTemp > MAX_TEMP)
                {
                    Console.Write("Valid temperatures range from -20 to 130. Please reenter the temperature: ");
                    validTemp = Int32.TryParse(Console.ReadLine(), out inputTemp);
                }

                //Calculate totals
                totalTemp += inputTemp;
                inputAmount++;
                
                Console.Write("Enter Temperatures from -20 to 130: ");
                validTemp = Int32.TryParse(Console.ReadLine(), out inputTemp);
            }

            //Calculate Average
            averageTemp = totalTemp / inputAmount;

            //Output to the console
            Console.WriteLine($"You entered {inputAmount} temperatures.");
            Console.WriteLine($"The mean temperature is {averageTemp:f1} degrees.");
        }
    }
}
