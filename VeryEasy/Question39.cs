namespace Practice.VeryEasy
{
    internal class Question39
    {
        public int FindLargestNum(int[] arr)
        {
            int b = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > b)
                {
                    b = arr[i];
                }
            }
            return b;
        }
        public int FindLargesNum1(int[] arr)
        {
            int b = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>b)
                {
                    b = arr[i];
                }
            }
            return b;
        }
        public int FindLargesNum2(int[] arr)
        {
            int b = arr[0];
            for (int i = 1; i<arr.Length;i++)
            {
                if (arr[i]>b)
                {
                    b = arr[i];
                }
            }
            return b;
        }
    }
}