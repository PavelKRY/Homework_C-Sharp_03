//Напишите программу, которая принимает на
//вход число (N) и помещает в массив таблицу
//кубов чисел от 1 до N. Полученный массив вывести на экран.
//
//3 -> [1, 8, 27]
//5 -> [1, 8, 27, 64, 125]
Console.WriteLine("Введите число, до которого будут выводится кубы чисел");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = new int [number];
int i = 0;
int n = 1;
for(i=0; i < number; n++,i++)
{
    array[i] = n*n*n;
    Console.Write(array[i] + " ");
}