using Aula194;
using System.Globalization;

Console.Write("Entre com o caminho completo do arquivo: ");
var sourceFilePath = Console.ReadLine();
var locale = CultureInfo.InvariantCulture;


try
{
    var lines = File.ReadAllLines(sourceFilePath!);
    var sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    var targetFolderPath = sourceFolderPath + @"\out";
    var targetFilePath = targetFolderPath + @"\sumary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using (var sw = File.AppendText(targetFilePath))
    {
        foreach (var line in lines)
        {
            var fields = line.Split(',');
            var name = fields[0];
            var price = double.Parse(fields[1], locale);
            var quantity = int.Parse(fields[2]);

            Product product = new Product(name, price, quantity);

            sw.WriteLine($"{product.Name}, {product.TotaPrice().ToString("F2", locale)}");
        }
    }

    using (var sr = File.OpenText("c:\\temp\\out\\sumary.csv"))
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
