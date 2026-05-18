string[] words = ["eat", "tea", "tan", "ate", "nat", "bat"];

Dictionary<string,List<string>> soartedWords = new Dictionary<string,List<string>>();

foreach(var word in words)
{
    //convert word in char array
    char[] arr = word.ToCharArray();

    //sort the char array
    Array.Sort(arr);

    //conver the sorted char array into string
    string sortedWord = new string(arr);
    if (soartedWords.ContainsKey(sortedWord))
    {
        soartedWords[sortedWord].Add(word);
    }
    else
    {
        soartedWords.Add(sortedWord,new List<string>(){word});
    }
}

foreach(var pair in soartedWords)
{
    System.Console.WriteLine(string.Join(",",pair.Value)+" have the same alphabets.");
}