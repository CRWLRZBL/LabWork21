namespace Task3
{
    internal class Program
    {
        static string GetSize(int bytes)
        {
            if (bytes < 1 << 10)
                return $"{bytes} Б";
            if (bytes < 1 << 20)
                return $"{bytes >> 10} КБ";
            if (bytes < 1 << 30)
                return $"{bytes >> 20} МБ";
            return $"{bytes >> 30} ГБ";
        }

        static void Main()
        {
            Console.WriteLine(GetSize(1024));
        }
    }
}
