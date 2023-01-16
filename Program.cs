Console.Clear();
Console.WriteLine("Введите кол-во элементов в массиве: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] arr=new int [N];
int kol=0;
for (int i=0;i<N;i++)
{
    arr[i]=new Random().Next(100,1000);
    if (arr[i]%2==0) kol+=1;
}
Console.WriteLine($"Кол-во четных элементов в масииве равно {kol}");