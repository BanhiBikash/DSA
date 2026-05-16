int[] arr = [1, 3, 5, 2, 4];
int[] arr2 = [1, 4, 5, 9, 8, 0];

int[] Union(int[] arr, int[] arr2)
{
    HashSet<int> hasSet = new HashSet<int>(arr);
    hasSet.UnionWith(arr2);

    int[] result = new int[hasSet.Count()];
    System.Console.WriteLine("Array length:" + result.Count());
    int i = 0;
    foreach (var e in hasSet)
    {
        System.Console.WriteLine("Hash element:" + e);

        result[i] = e;
        System.Console.WriteLine($"Array {i} element:" + result[i++]);
    }
    return result;
}

System.Console.WriteLine($"The union array for {string.Join(",",arr)} and {string.Join(",",arr2)} is {string.Join(",",Union(arr,arr2))}");