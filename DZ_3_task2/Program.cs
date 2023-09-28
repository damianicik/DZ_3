/*Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов 
чисел от 1 до N (включительно) каждое на новой строке.*/

Console.WriteLine("введите число: ");
int ShowCube = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=ShowCube; i++)// i++ увеличение индекса на 1
{
    System.Console.Write($"{Math.Pow(i,3)} ");
    Console.WriteLine();
}
// System.Console.WriteLine();// чтоб был пробел между числами в выводе
