Console.WriteLine("Введите кол-во чисел: ");
int M=Convert.ToInt32(Console.ReadLine());
int[] arr=new int [M];
int kol=0;
for (int i=0;i<M;i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if (arr[i]>0) kol++;
}
Console.WriteLine($"Кол-во положительный чисел равно {kol}");