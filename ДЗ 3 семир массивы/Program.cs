// 1 Задание

// void FillArray (int[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(1,100);
//         Console.Write (Arr[i]+" ");
//     }
// }

// int [] array = new int [10];
// FillArray(array);
// int count=0;
// for (int i=0; i<10; i++)
// {
//     if (array[i]<=90 && array[i]>=20) count++;
// }
// Console.WriteLine();
// Console.Write(count);



// 2 Задание

// void FillArray (int[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(1,100);
//         Console.Write (Arr[i]+" ");
//     }
// }

// int [] array = new int [10];
// FillArray(array);
// int count=0;
// for (int i=0; i<10; i++)
// {
//     if (array[i]%2==0) count++;
// }
// Console.WriteLine();
// Console.Write(count);

// 3 Задание

// void FillArray (double[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(100,10000)*0.01 ;

//         Console.Write (Arr[i]+" ");
//     }
// }

// double [] array = new double [10];
// FillArray(array);
// double max=array[0];
// double min=array[0];
// for (int i=0; i<10; i++)
// {
//     if (array[i] > max) max=array[i];
//     else if (array[i]<min) min= array[i];
// }
// double delta = max - min;
// Console.WriteLine();
// Console.WriteLine(max+" "+min+" "+delta);