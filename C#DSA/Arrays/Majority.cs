int[] arr = [1,3,2,3,2,2,2,2];

int Majority(int[] arr)
{
    int candidate = arr[0];
    int count =0;

    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] == candidate)
        {
            count++;
        }
        else
        {
            if (count == 0)
            {
                candidate=arr[i];
            }else if (count > 0)
            {
                count--;
            }
        }
        Console.WriteLine($"Iteration:{i}, element:{arr[i]},candidate:{candidate}, count:{count}");
    }

    if (count > 0)
    {
        return candidate;
    }
    else
    {
        Console.WriteLine("None in majority");
        return 0;
    }
}

Console.WriteLine("The number in majority is "+Majority(arr));