//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int n1 = new Random().Next(1,10);
int n2 = new Random().Next(1,10);

int res = GetNum(n1, n2);
System.Console.WriteLine($"{n1}, {n2} -> {res}");

int GetNum(int num1, int num2)
{
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    
    int result = Convert.ToInt32(Math.Pow(num1, num2));

    return result;
}