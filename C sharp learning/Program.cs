using System;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            double num;
            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine());

            if (num > 18.23d && num < 50)
            {
                Console.WriteLine("You are older than 18.23");
            }
            else if(num < 10)
            {
                Console.WriteLine("Under 10");
            }
            else
            { 
                Console.WriteLine("Your little Boy:)"); 
            }
            string name = num == 15 ? "Airat" : "Ramis Pizdaliz";
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
