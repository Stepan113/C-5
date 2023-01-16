Console.Clear();
Console.WriteLine("Введите кол-во элементов в массиве: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] arr=new int [N];
int sum_=0;
for (int i=0;i<N;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
    if (i%2!=0) sum_+=arr[i]; 
}
Console.WriteLine(sum_);