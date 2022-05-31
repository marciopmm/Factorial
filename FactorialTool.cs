namespace Factorial
{
    public class FactorialTool
    {
        public int CalculateLoopBackward(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int CalculateLoopFoward(int n)
        {
            var factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int CalculateRecursion(int n)
        {
            if (n == 1)
                return 1;
            
            return n * CalculateRecursion(n - 1);
        }
    }
}