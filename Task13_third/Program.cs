int numberA = 0;
int numberB = 0;

Console.Write("Введите число: ");
numberA = int.Parse(Console.ReadLine());


if (numberA > 100);   // ошибка тут, не нужно ставить ; после скобок
 {
    while (numberA > 1000)
{
    numberA /= 10;
}
    
    numberB = numberA % 10;
    Console.Write($"Третья цифра числа {numberA} - это {numberB} ");
 }
else 
 Console.Write ($"В числе {numberA} нет третьей цифры"); 
 

if (true // тут у нас стоит условие)
{
  // действие когда условие выполняется
}
else
{
  // действие когда условие НЕ выполняется
}
