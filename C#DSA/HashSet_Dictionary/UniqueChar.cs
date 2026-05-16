string str = "leetcodelove";

int Unique(string str)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char e in str)
    {

        if (!charCount.ContainsKey(e))  //if not present then add e and set count=1
        {
            charCount.Add(e, 1);
        }
        else    //if present then count++
        {
            charCount[e]++;
        }
    }

    for(int i=0;i< str.Length;i++)
    {
        if(charCount[str[i]]==1)
        return i;
    }

    return -1;
}

System.Console.WriteLine($"The first uinque element in {str} at {Unique(str)} is {str[Unique(str)]}.");