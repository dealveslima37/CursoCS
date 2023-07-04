using System.Globalization;
using Aula211;

var path = @"c:\temp\emps.csv.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> emps = new();
        while (!sr.EndOfStream)
        {
            emps.Add(new Employee(sr.ReadLine()!));
        }
        
        emps.Sort();
        emps.ForEach(e => Console.WriteLine(e));
    }
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}