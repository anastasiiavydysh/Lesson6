//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Використовуючи цикли та метод: Console.Write("*"), Console.Write(" "),
//Console.Write("\n")(для переходу на новий рядок).Виведіть на екран:
//прямокутник

for(int i=0;i<5;i++)
{
    if (i == 0 || i == 4)
    {
        for (int j = 0; j < 20; j++)
        {
            Console.Write("*");
            if(j == 19)
               Console.Write("\n");
        }
    }
    else
    {
        for (int j = 0; j < 20; j++)
        {
            if (j == 0)
                Console.Write("*");
            else
            {
                if (j == 19)
                {
                    Console.Write("*");
                    Console.Write("\n");
                }
                else
                    Console.Write(" ");
            }
        }
    }
}
Console.WriteLine("_________________________________________________");
//прямокутний трикутник
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");        
    }
    Console.Write("\n");
}
Console.WriteLine("_________________________________________________");
//рівносторонній трикутник
for (int i = 0; i < 5; i++)
{   
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    for(int j=0;j<i;j++)
    {
        Console.Write("*");
    }
    for(int j=0;j<i;j++)
    {
        Console.Write("*");
    }
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    Console.Write("\n");
}
Console.WriteLine("_________________________________________________");
//ромб
for (int i = 0; i < 5; i++)
{
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    Console.Write("\n");
}
for (int i = 5; i > 0; i--)
{
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    Console.Write("\n");
}