int[] arr = [1,2,3,4,5,6,78];
int[] arr2 = [1,3,5,3,6,7,2];

bool isDuplicate(int[] arr)
{
    bool unique = true;
    var x = new HashSet<int>();

    foreach(var e in arr)
    {
        if (!x.Add(e))
        {
            unique=false;
            break;
        }
    }

    return unique;
}

Console.WriteLine("Array 1 is unique: "+isDuplicate(arr));
Console.WriteLine("Array 2 is unique: "+isDuplicate(arr2));
