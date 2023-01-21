// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? numb = Console.ReadLine();
int numericValue;
bool isNumb = int.TryParse(numb,out numericValue);
if (isNumb == true && numb![0] == numb[4] && numb[1] == numb[3])
{
    System.Console.WriteLine("Да");
}
else if (isNumb == false)
{
    System.Console.WriteLine("Введено не число");
}
else
    System.Console.WriteLine("Нет");