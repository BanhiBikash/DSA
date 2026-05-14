using System.Globalization;

int[] arr = [1,7,4,8,4,9,4,7,8,4];

int[] Product(int[] arr)
{
    int[] result = new int[arr.Length];

    //setting the left product of 1st element as itself
    result[0] = 1;

    //finding left sum
    for (int i=1;i<arr.Length;i++)
    {
        result[i]=result[i-1]*arr[i-1];
    }

    int rightproduct=1;

    //finding right sum
    for(int i = arr.Length - 1; i >= 0; i--)
    {
        result[i]=result[i]*rightproduct;
        rightproduct = rightproduct*arr[i];
    }

    return result;
}

Console.WriteLine($"The product of {string.Join(",",arr)} is {string.Join(",",Product(arr))}.");