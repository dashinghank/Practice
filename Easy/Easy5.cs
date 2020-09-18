namespace Practice.Easy
{
    internal class Easy5
    {
        public string FormatDate(string date)
        {
            string[] part = date.Split('/');
            return $"{part[2]}{part[1]}{part[0]}";
        }

        public string FormatDate1(string date)
        {
            string[] part = date.Split('/');
            return $"{part[2]}{part[1]}{part[0]}";
        }

        public string FormatDate2(string date)
        {
            string[] part = date.Split('/');
            return $"{part[2]}{part[1]}{part[0]}";
        }
    }
}