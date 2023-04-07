using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace HomeWorkModule4_unit_4._1._18
{
    internal class Program
    {
        static void Main(string[] args)

        {

            (string name, string lastname, string login, int lengthLogin, bool isHavePet, int age, string[] colors) anketa;

            anketa.colors = new string[3];

            Console.Write("Введите имя: ");
            anketa.Item1 = Console.ReadLine();
            Console.Write("Введите фамилия: ");
            anketa.Item2 = Console.ReadLine();
            Console.Write("Введите логин: ");
            anketa.Item3 = Console.ReadLine();
            anketa.Item4 = anketa.Item3.Length;
            Console.WriteLine($"Длина вашего логина: {anketa.Item4}");
            Console.Write("Есть ли у вас домашнее животное ? (Напишите Да или Нет): ");
            string havePet = Console.ReadLine();

            if (havePet == "Да")
                anketa.isHavePet = true;
            else
            {
                anketa.isHavePet = false;

            }
            Console.WriteLine(anketa.isHavePet);

            Console.Write("Введите ваш возраст: ");
            anketa.Item6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите три любимых цвета: ");
            for (int i = 0; i < anketa.colors.Length; i++)
            {
                string color = Console.ReadLine();
                anketa.colors[i] = color;
            }
            Console.WriteLine();

            foreach (var x in anketa.colors)
                Console.Write($"Ваши любимые цвета: {x}\n");

        }
    }
}