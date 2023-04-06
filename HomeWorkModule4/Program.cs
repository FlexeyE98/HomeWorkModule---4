namespace HomeWorkModule4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите ваш любимый цвет: ");
            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;


            }

            else if (color == "yellow")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.White;

            }

            else
            {
                Console.WriteLine($"Ваш любимый цвет {color}, увы, в наши планы он не входил, поэтому используем дефолтный цвет :)");
            }



        }
    }
}