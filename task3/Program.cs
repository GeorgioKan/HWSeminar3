// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число N: ");
double N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 0; i <= N; i++)
    {
        double answer = Math.Pow(i,3);
        System.Console.WriteLine(answer + " ");
    }
}
else
System.Console.WriteLine("Число отрицательно или равно 0");