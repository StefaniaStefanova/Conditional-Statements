using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            if (inp == "square")


            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:F3}");

            }


            else if (inp == "rectangle")


            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = w * h;
                Console.WriteLine($"{area:F3}");

            }

            else if (inp == "circle")


            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine($"{area:F3}");

            }

            else if (inp == "triangle")


            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b / 2;
                Console.WriteLine($"{area:F3}");

            }



        }
    }    }  

