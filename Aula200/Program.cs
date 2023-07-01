var path = @"c:\temp";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("Pastas");
    foreach (string folder in folders)
    {
        Console.WriteLine(folder);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine();
    Console.WriteLine("Arquivos");
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + "\\newFolder");

}
catch (IOException e)
{
    Console.WriteLine(e.ToString());
}
