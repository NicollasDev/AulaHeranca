using System;

namespace Aula06Herança
{
    class Program
    {
        static void Main(string[] args)
        {
           CPF cpf = new CPF();
           cpf.none ="Nicollas";
           System.Console.WriteLine( cpf.Saudar() );

           cpf.cpf = "923.136.524-20";
           System.Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
