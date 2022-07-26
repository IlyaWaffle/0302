int A = 0;
int B = 0;

Console.Write("Введите трехзначное число: ");
A = int.Parse(Console.ReadLine());

B = A / 10 % 10;

System.Console.WriteLine($"Вторая цифра числа {A} - это {B} ");

