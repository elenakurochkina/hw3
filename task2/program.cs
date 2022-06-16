//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
System.Console.Write(message);
string x = Console.ReadLine();
return int.Parse(x);
}
int x1 = Prompt("enter coordinate x1: ");
int x2 = Prompt("enter coordinate x2: ");
int y1 = Prompt("enter coordinate y1: ");
int y2 = Prompt("enter coordinate y2: ");
int z1 = Prompt("enter coordinate z1: ");
int z2 = Prompt("enter coordinate z2: ");

double a = Math.Sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2);
System.Console.WriteLine($"distance is: {a:F3}");