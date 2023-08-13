using System.Collections.Generic;

var set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));

foreach (var item in set)
{
    Console.WriteLine(item);
}


