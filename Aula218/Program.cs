SortedSet<int> a = new() { 10, 1, 2, 5, 4 };
SortedSet<int> b = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
SortedSet<int> c = new(a);
c.UnionWith(b);

foreach (var i in c)
{
    Console.Write(i + " ");
}


