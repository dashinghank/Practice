namespace Practice.VeryEasy
{
    internal class Question41
    {
        public int CountTrue(bool[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountTrue1(bool[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountTrue2(bool[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}