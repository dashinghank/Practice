namespace Practice.VeryEasy
{
    internal class Question43
    {
        public int DifferenceMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return max - min;
        }

    }
}