namespace Practice.Easy
{
    internal class Easy2
    {
        public int[] SortNumsAscending(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return new int[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
            return arr;
        }
        public int[] SortNumsAscending1(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return new int[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
            return arr;
        }
        public int[] SortNumsAscending2(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return new int[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
            return arr;
        }
    }
}