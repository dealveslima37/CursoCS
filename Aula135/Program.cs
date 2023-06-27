using Entities;

namespace Aula135;

class Program
{
    static void Main(string[] args)
    {
        
        var bussinessAccount = new BussinessAccount(8010, "Bob Brown", 100.0, 500.0);

        Console.WriteLine(bussinessAccount.Balance);

    }
}