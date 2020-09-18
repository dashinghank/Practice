namespace Practice.Easy
{
    internal class Easy21
    {
        public int Equal(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return 3;
            }
            if (a == b || b == c || a == c)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public int Equal1(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return 3;
            }
            if (a == b || b == c || c == a)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public int Equal2(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return 3;
            }
            if (a == b || b == c || c == a)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}