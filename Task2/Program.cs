Console.Write("Введите два числа:" );
int a, b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine( "наибольшее число {0}" ,a );

}
else
{
    Console.WriteLine( "наибольшее число {0}" ,b );
}
