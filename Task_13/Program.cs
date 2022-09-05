int Func (int x1)
{
    x1=x1%10;
    Console.WriteLine($"Третья цифра {x1}");
    return x1;
}

Console.WriteLine("Введите  число");
int a1=Convert.ToInt32(Console.ReadLine());
if (a1<100) 
  { Console.WriteLine("Такой цыфры нет");  }
else 
{  
    if (a1>=1000)
    {
        while (a1>1000)
        {
        a1=a1/10; 
        }
    }
Func(a1);
}