namespace Practice
{
    internal class Question66
    {
        public string SmallerNum(string n1, string n2)
        {
            if (n1.Length < n2.Length)
                return n1;
            else if (n1.Length > n2.Length)
                return n2;
            else
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    if (n1[i] < n2[i])
                        return n1;
                    else if (n1[i] > n2[i])
                        return n2;
                }
                return n1;
            }
        }
        public string SmallerNum1(string n1, string n2)
        {
            if (n1.Length < n2.Length)
            {
                return n1;
            }
            else if (n1.Length > n2.Length)
                return n2;
            else
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    if (n1[i]<n2[i])
                    {
                        return n1;
                    }
                    else if (n1[i]>n2[i])
                    {
                        return n2;
                    }
                }
                return n1;
            }
        }

    }
}
