//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите 5-ти значное число");
char[] array = Console.ReadLine().ToArray();
var arrayValue = string.Join(" ", array);

if (array.Length > 4 && array.Length < 6)
{
        if (array[0] == array[4] && array[1] == array[3])
        {
            Console.WriteLine($"Массив {arrayValue} - является палиндромом!");
        }
        else
        {
            Console.WriteLine($"Массив {arrayValue} не является палиндромом!");
        }
}
else
{
    Console.WriteLine("Массив состоит не из 5 символов");
}
