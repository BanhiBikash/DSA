int[] arr =[1,3,2,4,2,5,3,1];

int[] unique = new HashSet<int>(arr).ToArray();

foreach(var e in unique)
{
    System.Console.WriteLine(e);
}