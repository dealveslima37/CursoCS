var path = @"c:\temp\in.txt";

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}
