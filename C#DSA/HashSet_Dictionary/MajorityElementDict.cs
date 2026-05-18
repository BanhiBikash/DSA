int[] arr = [2,2,1,1,2,2];

int Majority(int[] arr)
{
    int n = arr[0];
    int count=0;

    for(int i=0;i<arr.Length;i++)
    {
        if (count == 0)
        {
            n=arr[i];
            count++;
        }else if (n == arr[i])
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    if (count > 0)
    {
        return n;
    }
    else{
        System.Console.WriteLine("No no. in majority.");
        return 0;  
    }
}

System.Console.WriteLine($"The no. in majority in {string.Join(",",arr)} is {Majority(arr)}.");