namespace Practice.VeryEasy
{
    internal class Question40
    {
        public double FindSmallNum(double[] arr)
        {
            double s = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (s > arr[i])
                {
                    s = arr[i];
                }
            }
            return s;
        }

        public double FindSmallNum1(double[] arr)
        {
            double s = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (s > arr[i])
                {
                    s = arr[i];
                }
            }
            return s;
        }

        public double FindSmallNum2(double[] arr)
        {
            double s = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (s > arr[i])
                {
                    s = arr[i];
                }
            }
            return s;
        }
    }
}