 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое числа:");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе числа:");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье числа:");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 > max) 
{  
     max = number1;
}
if (number2 > max) 
    {
    max = number2;
    } 
if (number3 > max) 

max = number3;

Console.Write("max = ");
Console.WriteLine(max);
