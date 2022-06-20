namespace Algorithms.Tests
{
    public class Remove5
    {
        /*
         * 12534
         * 1234
         * 
         * result: 34
         * digit: 5
         * number: 125
         * power: 100
         * 
         * result: 4 
         * digit: 3
         * number: 1253
         * power: 10
         * 
         */
        public static int Run(int number)
        {
            int result = 0;
            int power = 1;
            while(number > 0)
            {
                int digit= number % 10;
                number /= 10;
                
                if (digit == 5)
                    return number * power + result;

                result = digit * power + result;

                power *= 10;
            }
            return result;
        }
    }
}