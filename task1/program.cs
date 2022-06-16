//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом

System.Console.Write("enter a five-digit number: ");
string x = Console.ReadLine();
int a = int.Parse(x);
if (a / 10000 == a % 10 && a / 1000 % 10 == a / 1000 % 10) System.Console.WriteLine("число является палиндромом");
else System.Console.WriteLine("число не является палиндромом");
