//Є N клієнтів, яким компанія-виробник має доставити товар. 
//Скільки існує можливих маршрутів доставки товару з урахуванням того, що товар доставлятиме одна машина?

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//Напишіть програму, яка розраховуватиме, і виводитиме на екран кількість можливих варіантів доставки товару. 
//Для вирішення задачі використовуйте факторіал N!, що розраховується за допомогою циклу do-while.
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of clients -> ");
            int numberOfClients = Convert.ToInt32(Console.ReadLine());
            while(numberOfClients <= 0)
            {
                Console.Write("Error, the number cannot be 0 or less than 0. Enter the number of clients -> ");
                numberOfClients = Convert.ToInt32(Console.ReadLine());
            }

            uint result = 1;
            do
            {
                result *= Convert.ToUInt32(numberOfClients);
                numberOfClients--;
            } 
            while (numberOfClients > 0);

            Console.WriteLine("Answer = " + result);
        }
    }
}