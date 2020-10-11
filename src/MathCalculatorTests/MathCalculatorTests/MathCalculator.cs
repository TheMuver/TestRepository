using System;

namespace MathCalculatorTests
{
    public class MathCalculator
    {
        public int Sum(int a, int b)
        {
            return a+b;
        }
        public int Sum(string a, string b)
        {
            int num_1;
            int num_2;

            return Convert.ToInt32(a) + Convert.ToInt32(b);

            if (int.TryParse(a, out num_1 ) && int.TryParse(b, out num_2 ))
            {
                return Convert.ToInt32(a) + Convert.ToInt32(b);
            }
            else  
            {
                return 0;
            }
        }

        public int Sub(int a, int b)
        {
            return a-b;
        }
    }
}
