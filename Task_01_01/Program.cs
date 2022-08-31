Console.WriteLine("Введите, пожалуйста, число 2ух или более разрядное");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int dump=number;
int dump1=number;
int temp = number;
int i = 0;
if(number >= 10)
{
    while(number != 0)
    {
        number=number/10;
        Console.WriteLine(number);
        count++;
    }
    Console.WriteLine("________________");
    Console.WriteLine(count);
    Console.WriteLine("________________");
    int [] array = new int [count];
    while(i<count)
    {
        array[i] = temp%10;
        temp = temp/10;
        Console.WriteLine(array[i]);
        i++;
      
    }
    int [] array1 = new int [count];
    int r = 0;
    int t = count -1;
while(r<count)
    {
        array1[r] = array[t];
        r++;
        t--;
    }
    double sum = 0;
    int j = 0;
    for (j = count -1;j>-1;j--)
    {
        sum += array1[j]*Math.Pow(10, j);
    }
    int sum1 = Convert.ToInt32(sum);
    Console.WriteLine(sum);
    if(sum1 == dump1)
    {
        Console.WriteLine("число является палиндромом");
    }
    else
    {
        Console.WriteLine("число не является палиндромом");
    }
}
else
{
    Console.WriteLine("введите число 2ух или более разрядное");
}
 
