int numberA = 0;
int numberB = 0;

Console.Write("Введите число: ");
numberA = int.Parse(Console.ReadLine());


if (numberA > 100);
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
 

