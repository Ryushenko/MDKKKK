while (true)
{
    Console.WriteLine("Введи число!");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введи число!");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите арифметический знак");
    var c = Console.ReadLine();

    if (c == "/")
    {
        Console.WriteLine(a / b);
    }
    else if (c == "+")
    {
        Console.WriteLine(a + b);
    }
    else if (c == "-")
    {
        Console.WriteLine(a - b);
    }
    else if (c == "*")
    {
        Console.WriteLine(a * b);
    }
}