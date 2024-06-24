namespace Task1
{
    internal class Program
    {
        static int GetSum(int a, int b) => a + b;

        static void Main()
        {
            Console.WriteLine($"Сумма чисел = {GetSum(10, 5)}");
        }
    }
}
