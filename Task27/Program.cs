//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int n1 = Convert.ToInt32(Console.ReadLine());
int res = GetNum(n1);

System.Console.WriteLine($"{res}");

int GetNum(int num)
{
    int result=0;
    System.Console.WriteLine(num);

   while(num>0)
   {
        result = result + num%10;
        num/=10;
   }

    return result;
}
