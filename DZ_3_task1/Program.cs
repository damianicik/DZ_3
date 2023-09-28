/* Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве.*/

double DistanceBetweenPoints(double x1, double y1, double x2, double y2, double z1, double z2)
{
double DistanceBetweenPoints = Math.Round (Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)), 3);
return DistanceBetweenPoints;
}

Console.WriteLine ("Введите x1");
double x1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите y1");
double y1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Введите x2");
double x2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите y2");
double y2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Введите z1");
double z1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите z2");
double z2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Расстояние равно " + DistanceBetweenPoints(x1, y1, z1, x2, y2, z2));
