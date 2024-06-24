namespace Task5
{
    internal class Program
    {
        static double GetPower(double number, int power)
        {
            if (power == 0)
                return 1;
            if (power < 1)
                return 1 / GetPower(number, -power);
            return number * GetPower(number, power - 1);
        }

        static void Main()
        {
            Console.WriteLine(GetPower(25, -5));
        }
    }
}
