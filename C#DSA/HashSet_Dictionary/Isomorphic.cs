string s = "bad";
string t = "bba";

Dictionary<char, char> map = new Dictionary<char, char>();

if (s.Length != t.Length)
{
    System.Console.WriteLine($"{s} and {t} are not ismorphic.");
}
else
{
    char[] arr1 = s.ToCharArray();
    char[] arr2 = t.ToCharArray();

    for (int i = 0; i < arr1.Length; i++)
    {
        //check if key is there
        if (map.ContainsKey(arr1[i]))
        {
            //if key is there then is the value matching
            if (map[arr1[i]] != arr2[i])
            {
                System.Console.WriteLine($"{s} and {t} are not ismorphic.");
                break;
            }
        }
        //check if value is there, if value is there but since the key is not then the pair is not isomorphic
        else if (map.ContainsValue(arr2[i]))
        {
            System.Console.WriteLine($"{s} and {t} are not ismorphic.");
            break;
        }
        //if neither the key or the value is there then add them
        else
        {
            map.Add(arr1[i], arr2[i]);
        }
        System.Console.WriteLine($"Pair checked:{arr1[i]},{arr2[i]}");

        if (i == arr1.Length - 1)
        {
            System.Console.WriteLine($"{s} and {t} are ismorphic.");
        }
    }
}