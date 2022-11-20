//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//  
//  Дано два числа A та B (A<B) виведіть суму всіх чисел розташованих між цими числами на екран.
//Дано два числа A та B (A<B) виведіть усі непарні значення, розташовані між даними числами

Console.Write("Enter A -> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B -> ");
int b = Convert.ToInt32(Console.ReadLine());

while (a >= b)
{
    Console.WriteLine("Please, enter A<B");
    Console.Write("Enter A -> ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter B -> ");
    b = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
for (int i = a; i < b; i++)
{
    sum += i;
    if (i % 2 != 0)
        Console.WriteLine("Odd number: "+i);
}
Console.WriteLine("Sum: "+sum);