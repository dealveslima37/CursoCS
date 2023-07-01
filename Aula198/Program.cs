string path = @"c:\temp\in.txt";
string targetPath = @"c:\temp\file3.txt";

try
{
    var lines = File.ReadAllLines(path);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (var line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }

    using(StreamReader sr = File.OpenText(targetPath))
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
