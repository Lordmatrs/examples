// нахождение максимум из 9 чисел
// Console.Clear();
// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }
// int [] array = {11, 20, 33, 43, 522, 61, 77, 84, 92};

// int result = Max (
//     Max (array[0], array[1], array[02]),
//     Max (array[3], array[4], array[05]),
//     Max (array[6], array[7], array[08]));

// Console.WriteLine(result);

// Console.Clear();
// int[] array = {11, 20, 33, 43, 33, 61, 77, 84, 92};
// int n = array.Length;
// int find = 92;
// int index = 0;
// while (index < n) 
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//     }
//     index++;
// }
Console.Clear();

void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
int[] array = new int [10];

Fillarray(array);
PrintArray(array);




