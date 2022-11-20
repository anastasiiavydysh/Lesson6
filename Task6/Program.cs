//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть дві цілі змінні і задайте їм деякі значення. 
//    Застосовуючи техніку вкладених циклів, намалюйте прямокутник із зірочок. 
//    Використовуйте значення раніше створених змінних для вказівки висоти та ширини прямокутника.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            for (int i = 0; i < (a < b ? a : b); i++)
            {
                for (int j = 0; j < (a < b ? b : a); j++)
                {
                    Console.Write('*');
                }                
                Console.WriteLine('*');
            }
        }
    }
}