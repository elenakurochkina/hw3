//Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N

System.Console.Write("enter number N: ");
string x = Console.ReadLine();
int N = int.Parse(x);
int a = 1;
while (a <= N)
{
    System.Console.WriteLine(a*a*a); 
    a++;
}
