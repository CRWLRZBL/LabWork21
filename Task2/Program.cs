namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            int n = 125;
            double radius1 = 10;
            double radius2 = 5;
            Console.WriteLine($"Площадь кольца = {Math.PI * ((radius1 - radius2) * (radius1 + radius2))}");
           
            Console.WriteLine($"Сумма натуральных чисел от 1 до {n} = {n * (1 + n) / 2}");
        }
    }
}
