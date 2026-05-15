int[] arr = [1,2,3,4,5,6,7];
int targetValue = 12;
List<int[]>? Pairs = new List<int[]>();

int start = 0;
int last = arr.Count()-1;

while (start < last)
{
    int sum = arr[start]+arr[last];

    if (sum == targetValue)
    {
        Pairs.Add([arr[start],arr[last]]);
        start++;
        last--;
    }else if (sum < targetValue)
    {
        start++;
    }
    else
    {
        last--;
    }
}

if(Pairs.Count==0){
    Console.WriteLine("No Pairs found");
}else{
    Console.WriteLine("The pairs are:");

    foreach(var pair in Pairs){
        Console.WriteLine("\n"+pair[0]+" and "+pair[1]);
    }
}