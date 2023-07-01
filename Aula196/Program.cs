var path = @"c:\temp\in.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine()!;
        Console.WriteLine(line);
    }

}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    if (sr != null) sr.Close();
}
