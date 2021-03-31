using System;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int result;

            if (number1 > number2)
                result = number1;
            else
                result = number2;

            return result;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int result;

            if (number1 > number2)
                result = number1;
            else
                result = number2;

            return result;
        }

        public int FindMaximum(int number1, int number2)
        {
            int result;

            if (number1 < number2)
                result = number1;
            else
                result = number2;

            return result;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int result;

            if (number1 < number2 )
                result = number1;
            else
                result = number2;

            return result;
        }
    }
}