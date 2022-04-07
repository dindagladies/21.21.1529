using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Numbers
    {
        public int result;
        public int FindMinimum(int number1, int number2)
        {
            result = 0;

            if (number1 < number2)
            {
                result = number1;
            }
            else if (number2 < number1)
            {
                result = number2;
            }
            else
            {
                Console.WriteLine("Number has same velue");
            }

            return result;
        }

        public int FindMinimum(int number1, int number2, int number3)
        {
            result = 0;

            if (number1 < number2 && number1 < number3)
            {
                result = number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                result = number2;
            }
            else if (number3 < number1 && number3 < number2)
            {
                result = number3;
            }
            else
            {
                Console.WriteLine("Number has same velue");
            }

            return result;
        }

        public int FindMaximum(int number1, int number2)
        {
            result = 0;

            if (number1 > number2)
            {
                result = number1;
            }
            else if (number2 > number1)
            {
                result = number2;
            }
            else
            {
                Console.WriteLine("Number has same velue");
            }

            return result;
        }

        public int FindMaximum(int number1, int number2, int number3)
        {
            result = 0;

            if (number1 > number2 && number1 > number3)
            {
                result = number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                result = number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                result = number3;
            }
            else
            {
                Console.WriteLine("Number has same velue");
            }

            return result;
        }
    }
