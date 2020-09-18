namespace Practice.VeryEasy
{
    internal class Question62
    {
        public int GetAbsSum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * -1;
                    result += arr[i];
                }
                else
                {
                    result += arr[i];
                }
            }
            return result;
        }

        public int GetAbsSum1(int[] arr)
        {
            int r = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    arr[i] = arr[i] * -1;
                    r += arr[i];
                }
                else
                {
                    r += arr[i];
                }
            }
            return r;
        }

        public int GetAbsSum2(int[] arr)
        {
            int r = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    arr[i] = arr[i] * -1;
                    r += arr[i];
                }
                else
                {
                    r += arr[i];
                }
            }
            return r;
        }
    }
}