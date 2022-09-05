//Console.WriteLine("Hello, World!");
int Func (int x1)
{
    x1=x1/10;
    x1=x1%10;
    Console.WriteLine($"Вторая цифра {x1}");
    return x1;
}
Console.WriteLine("Введите трехзначное число");
int a1=Convert.ToInt32(Console.ReadLine());
Func(a1);