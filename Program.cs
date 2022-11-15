// Задача на нахождение большего числа
// Console.WriteLine ("Введите числa ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите числa ");
// int b = int.Parse(Console.ReadLine()!);
// if (a>b) {Console.WriteLine("Первое чило больше второго");}
// else{Console.WriteLine("Второе число больше первого");}


// Задача на нахождение максимального из трёх чисел
// Console.WriteLine ("Введите числa ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите числa ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите числa ");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (max<b) {Console.WriteLine("Максимальное число b");}
// if (max<c) {Console.WriteLine("Максимальное число c");}


//На нахождение чётного\нечётного числа 
// Console.WriteLine ("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// if (a % 2 == 0) {Console.WriteLine("Чётное число");}
// else {Console.WriteLine("Нечётное число");}

Console.WriteLine ("Введите длину ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0) Console.WriteLine($"{i}" );
    i++;
    }
