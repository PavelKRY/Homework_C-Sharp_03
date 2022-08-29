//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите, пожалуйста, поочерёдно координаты первой точки");
Console.WriteLine("x=");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y=");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z=");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, поочерёдно координаты второй точки");
Console.WriteLine("x=");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y=");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z=");
int z1 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((x1 - x)*2 + (y1 - y)*2 + (z1 - z)*2);
double result1 = Math.Round(result,2);
Console.WriteLine("Расстояние между двумя точками = " + result1);

