using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User client = new User();
            client._firstName = "Ashot";
            client._surname = "Ashotyan";
            string Fullname = client.FullName;
            client._age = 19;
            Guid id = client._id;
            client._salary = 500000;

            Console.WriteLine($"Clients full name {Fullname} : ID {id} : Age {client._age}: Salary = {client._salary}AMD");
            Console.WriteLine();

            Bank ABB = new Bank();
            string loan = ABB.Loan(2000000, client._salary);
            Console.WriteLine(loan);
            Console.WriteLine();

            ABB.Balance = 5000;
            Console.WriteLine(ABB.Balance);
            ABB.Transfer = 300;
            Console.WriteLine(ABB.Transfer);

            Console.ReadKey();
        }
    }
}
