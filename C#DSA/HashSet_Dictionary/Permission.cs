var request = new HashSet<string>(["read","write","dropTable"]);
var allowed = new HashSet<string>(["read","write","delete","execute"]);

System.Console.WriteLine("The requested opertaions are allowed:"+request.IsSubsetOf(allowed));