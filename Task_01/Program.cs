//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций 
//(не рассматривая число как тип данных string)
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите, пожалуйста, пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    int tempA = number%10;
    int tempB = number/10000;
    int tempC = (number/1000)%10;
    int tempD = (number/10)%10;
    if(tempA == tempB && tempC == tempD)
    {
        Console.WriteLine("Введёное вами число " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Введёное вами число " + number + " не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное значное число,пожалуйста, введите пятизначное число");
}