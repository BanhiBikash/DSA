int[] nums = { 3, 4, 7, 2, -3, 1, 4, 2, 0, 6 };
int target = 7;

List<int[]> TotalSubArray(int[] arr,int k)
{
    int sum = 0;
    List<int[]> Arrays = new List<int[]>();
    Dictionary<int,List<int>> PrefixSum = new Dictionary<int,List<int>>(); //prefixSum--indices

    //the first entry is sum 0 at index 0
    PrefixSum.Add(0,new List<int>(){0});

    for(int i = 0; i < arr.Length; i++)
    {
        //find the current sum
        sum+=arr[i];

        // check the complement was present or not
        if (PrefixSum.ContainsKey(sum-k))
        {
            //all the indices at which the complement is found can start a new sub array with the current index as end
            foreach(int start in PrefixSum[sum - k])
            {
                Arrays.Add(new int[]{start,i});
            }
        }

        //adding the current record
        if (PrefixSum.ContainsKey(sum))
        {
            PrefixSum[sum].Add(i);
        }
        else
        {
            PrefixSum[sum]=new List<int>{i};
        }
    }

    return Arrays;
}

// 2. Your completed, professional-grade Console line:
System.Console.WriteLine($"The total no. of subarrays possible is {TotalSubArray(nums, target).Count} and the arrays are {string.Join(", ", TotalSubArray(nums, target).Select(pair => $"[{pair[0]} to {pair[1]}]"))}");