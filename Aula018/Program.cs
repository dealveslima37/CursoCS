
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

string produto1 = "computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.00;
double preco2 = 650.0;
double medida = 53.234567;

Console.WriteLine("Produtos");
Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2")}");
Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2")}");
Console.WriteLine($"Registro {idade} anos de idade, código {codigo} e gênero: {genero}");

Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
Console.WriteLine($"Arrendondando (três casas decimais): {medida.ToString("F3")}");
Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", locale)}");





