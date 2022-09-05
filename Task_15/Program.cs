void Func (int x1)
{
   if (x1>7||x1==0) Console.WriteLine("Неправильный ввод");
   else 
   { 
    if (x1==7||x1==6) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий день");
   }
    
}
Console.WriteLine("Введите День Недели");
int a1=Convert.ToInt32(Console.ReadLine());
Func(a1);
