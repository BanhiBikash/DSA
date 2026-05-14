int[] arr = [1,7,4,84,9,4,7,0,4];

int[] Reverser(int[] arr)
{
    for(int i = 0; i <= arr.Length/2; i++)
    {
        int last = arr.Length-1-i;
        if (i < last)
        {
            int temp = arr[i];
            arr[i] = arr[last];
            arr[last] = temp;
        }
    }

    return arr;
}

Console.WriteLine($"reverse of {string.Join(",",arr)} is {string.Join(",",Reverser(arr))}");