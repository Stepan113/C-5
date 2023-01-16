// Console.Clear();
// Console.WriteLine("Введите кол-во элементов в массиве: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int [N];
// int max_el=0;
// int min_el=0;
// for (int i=0;i<N;i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
//     for (int j=0;j<N-1;j++)
//     {
//         for (int s=0;s<N-1-j;s++)
//         {
//             if (arr[s]>arr[s+1])
//             {
//                 (arr[s],arr[s+1])=(arr[s+1],arr[s]);
//             }
//         }
    
//     }
// }
// Console.WriteLine(arr[N-1]-arr[0]);
Console.Clear();
Console.WriteLine("Введите кол-во элементов в массиве: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] arr=new int [N];
for (int i=0;i<N;i++)
{
    arr[i]=new Random().Next(-150,151);
}
Console.WriteLine(arr.Max()-arr.Min());