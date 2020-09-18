namespace Practice.VeryEasy
{
    internal class Question67
    {
        public double[] FindMinMax(double[] values)
        {
            double big = values[0];
            double small = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (big < values[i])
                {
                    big = values[i];
                }
                if (small > values[i])
                {
                    small = values[i];
                }
            }
            double[] r = new double[] { small, big };
            return r;
        }
        public double[] FindMinMax1(double[] values)
        {
            double big = values[0];
            double small = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (big < values[i])
                {
                    big = values[i];
                }
                if (small > values[i])
                {
                    small = values[i];
                }
            }
            double[] r = new double[] { small, big };
            return r;
        }
        public double[] FindMinMax2(double[] values)
        {
            double big = values[0];
            double small = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (big < values[i])
                {
                    big = values[i];
                }
                if (small > values[i])
                {
                    small = values[i];
                }
            }
            double[] r = new double[] { small, big };
            return r;
        }
    }
}