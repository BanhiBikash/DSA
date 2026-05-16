int[] arr = [1,2,3,4,9,4,8];
int target = 7;

int[] TargetIndice(int[] arr, int target)
{
    Dictionary<int,int> Pairs = new Dictionary<int, int>();

    for(int i = 0; i < arr.Length; i++)
    {
        if (Pairs.ContainsKey(target - arr[i]))
        {
            return [i,Pairs[target-arr[i]]];
        }

        //we should add pairs at the end
        Pairs.Add(arr[i],i);
    }

    return [0,0];
}

System.Console.WriteLine($"The target {target} is acheived by the indices {string.Join(",",TargetIndice(arr,target))}.");
