using Aula199;

Console.Write("Deseja cadastrar quantas pessoas: ");
var n = int.Parse(Console.ReadLine()!);

List<Person> persons = new();

Console.WriteLine("Digita os dados da pessoa");
for (int i = 0; i < n; i++)
{
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();

    persons.Add(new Person { Name = name, Email = email });
}

var path = @"c:\temp\person.txt";

try
{

    using (var sw = File.AppendText(path))
    {
        foreach (var person in persons)
        {
            sw.WriteLine($"Nome: {person.Name} Email: {person.Email}");
        }
    }

    using (var sr = File.OpenText(path))
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


