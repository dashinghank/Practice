namespace Practice.VeryEasy
{
    internal class Question63
    {
        public string MonthName(int num)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[num - 1];
        }
        public string MonthName1(int n)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[n - 1];
        }
        public string MonthName2(int n)
        {
            string[] m = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return m[n - 1];
        }
    }
}