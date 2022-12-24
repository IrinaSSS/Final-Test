using static System.Console;

WriteLine("Введите количество элементов массива");

int N = Convert.ToInt32(ReadLine());
string[] array = new string[N];

WriteLine("Задайте ваш массив");
for (int i = 0; i < N; i++)
{
    array[i] = ReadLine()!;
}

string [] newArray (string [] array)
{
string[] a = new string[array.Length];
int j=0;
for (int i = 0; i < N; i++)
 {  
   if (array[i].Length <= 3)
    {   a[j] = array[i];
        j++;
    }
 }
 return a;
}

WriteLine("Новый массив:");
string [] a = newArray (array);
for (int i = 0; i < a.Length; i++)
{
    Write(a[i] + "\t ");
}