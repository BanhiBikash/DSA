int[] arr = [1, 3, 0, 7, 0, 8, 6, 9];

void MoveZeroes(int[] arr)
{
    int lastZeroIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("i:"+i+",least0Index:"+lastZeroIndex);
        Console.WriteLine("arr[i]:"+arr[i]+",arr[least0Index]:"+arr[lastZeroIndex]);
        if (arr[i] != 0)
        {
            arr[lastZeroIndex] = arr[i];
            lastZeroIndex++;
        }
    }

    //Fill the remaining space with zeroes
    for (int i = lastZeroIndex; i < arr.Length; i++)
    {
        arr[i] = 0;
    }
}

//test Case
MoveZeroes(arr);
Console.WriteLine(string.Join(",", arr));

//so the lastzero index starts from the beginning and only stores non 0 values, if 0 it does not move forward or store the int, 
//when non zero it stores the int and then moves forward to see if there is an int that can be stored in that position,
//at the end of the iteration we find lastzero index at the first index from where 0s start,so we fil the rest with zeroes.