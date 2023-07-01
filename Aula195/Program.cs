string sourcePath = "c:\\temp\\in.txt";
string targetPath = "c:\\temp\\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);

    String[] lines = File.ReadAllLines(sourcePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

}
catch (IOException e)
{
    Console.WriteLine("Um erro ocorreu");
    Console.WriteLine(e.Message);
}