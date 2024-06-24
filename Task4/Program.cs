namespace Task4
{
    internal class Program
    {
        private static int GetDaysCount(int month, int year)
        {
            if (month < 1 || month > 12 || year < 0)
                return 0;

            bool bissextileYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
            int[] months = { 31, bissextileYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return months[month - 1];
        }

        static void Main()
        {
            Console.WriteLine($"Кол-во дней в месяце: {GetDaysCount(2, 1584)}");
        }
    }
}
