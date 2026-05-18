int[] nums = { 3, 4, 7, 2, -3, 1, 4, 2, 0, 6 };
int target = 7;

int TotalSubArray(int[] arr,int k)
{
    int sum = 0;
    int totalArray = 0;
    Dictionary<int,int> PrefixSum = new Dictionary<int, int>(); //prefix,count
    PrefixSum.Add(0,1);

    for(int i = 0; i < arr.Length; i++)
    {
        //find the current sum
        sum+=arr[i];

        // check the complement was present or not
        if (PrefixSum.ContainsKey(sum-k))
        {
            totalArray+=PrefixSum[sum-k];
        }

        //adding the current record
        if (PrefixSum.ContainsKey(sum))
        {
            PrefixSum[sum]++;
        }
        else
        {
            PrefixSum.Add(sum,1);
        }
    }

    return totalArray;
}

System.Console.WriteLine(TotalSubArray(nums,target));