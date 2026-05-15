int[] arr = [-2, 1, -3, 4, -1, 2, 1];

int sum;
int maxSoFar;

int Sum(int[] arr)
{
    sum = arr[0];
    maxSoFar = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] + sum > 0)
        {
            sum+=arr[i];
            if(sum>maxSoFar)maxSoFar=sum;
        }
        else if(arr[i]+sum<0)
        {
            sum=0;
        }
    }
    return maxSoFar;
}

int[] SubArray(int[] arr)
{
    sum=arr[0];
    maxSoFar=arr[0];
    int start = 0;
    int end = 0;
    int temp=0;

    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > sum + arr[i])  //sum is -ve
        {
            sum=arr[i];
            temp=i; //probable restart of subarray
        }
        else
        {
            sum+=arr[i];
        }

        //check the max so far and look to finish the array
        if (sum > maxSoFar)
        {
            maxSoFar=sum;
            start=temp;
            end=i;
        }
    }

    return arr[start..(end+1)];
}

Console.WriteLine($"Max subarray sum is {Sum(arr)}.");
System.Console.WriteLine($"Subarray is {string.Join(",",SubArray(arr))}");