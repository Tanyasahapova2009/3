//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double x=0,y=0,z=0,x1=0,y1=0,z1=0,ab=0;

Console.WriteLine("Введите координаты первой точки");
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());
ab=Math.Sqrt((x1-x)*(x1-x) + (y1-y)*(y1-y) + (z1-z)*(z1-z));
Console.WriteLine(ab);

