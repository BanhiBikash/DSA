int[] arr = [1, 3, 0, 7, 0, 8, 6, 9];

int[] MaxSubArray(int[] arr, int k)
{
    if (k > arr.Length)
    {
        System.Console.WriteLine($"A sub-array of {k} is not possible in an array of {arr.Length}.");
        return [0,0,0];
    }
    int sum =arr[0];
    int maxSum = arr[0];
    int start = 0;
    int end=k;

    for(int i = 0; i < k; i++)
    {
        maxSum+=arr[i];
        sum=maxSum;
    }

    for(int i = k; i < arr.Length; i++)
    {
        sum=sum-arr[i-k]+arr[i];

        System.Console.WriteLine($"Element:{arr[i]},sum:{sum},maxSum:{maxSum}");
        if (maxSum < sum)
        {
            maxSum=sum;
            start=i-k+1;
            end=i;
        }
    }

    return arr[start..(end+1)];
}

System.Console.WriteLine($"The max subarray of {string.Join(",",arr)} of length 3 is {string.Join(",",MaxSubArray(arr,3))}.");