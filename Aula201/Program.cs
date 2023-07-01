string path = @"c:\temp\newFolder\arquivo7.txt";

Console.WriteLine($"Caminho do arquivo: " + Path.GetDirectoryName(path));
Console.WriteLine("Separador de caracteres: " + Path.DirectorySeparatorChar);
Console.WriteLine(Path.PathSeparator);
Console.WriteLine(Path.GetFileName(path));
Console.WriteLine(Path.GetFileNameWithoutExtension(path));
Console.WriteLine(Path.GetExtension(path));
Console.WriteLine(Path.GetFullPath(path));
Console.WriteLine(Path.GetTempPath());
