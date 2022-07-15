Console.Write("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("Наибольшее число = " + a);
}
else 
if (b>c)
{
    Console.WriteLine("Наибольшее число = " + b); 
}
else 
{
    Console.WriteLine("Наибольшее число = " + c);
}



