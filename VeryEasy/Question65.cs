namespace Practice.VeryEasy
{
    internal class Question65
    {
        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public int Factorial1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial1(n - 1);
            }
        }

        public int Factorial2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial2(n - 1);
            }
        }
    }
}