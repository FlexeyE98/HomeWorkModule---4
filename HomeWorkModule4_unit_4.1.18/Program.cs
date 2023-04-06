namespace HomeWorkModule4_unit_4._1._18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите ваш любимый цвет: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.WriteLine("Такого цвета мы не знаем, используйте дефолтные настройки консоли :)");
                    break;



            }




        }
    }
}