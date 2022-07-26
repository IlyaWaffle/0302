int day = 0;


Console.Write("Введите число от 1 до 7: ");
day = int.Parse(Console.ReadLine());

if (day < 6)
    Console.Write ("Это рабочий день");

else 
 Console.Write ("Это выходной");