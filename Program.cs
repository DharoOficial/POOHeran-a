using System;

namespace HerançaPOO06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            CPF cpf1 = new CPF();
            Pessoa Erick = new Pessoa();
            CNPJ cnpj1 = new CNPJ();

            System.Console.WriteLine(cpf1.saudacao());
            System.Console.WriteLine(Erick.saudacao());
            System.Console.WriteLine(cnpj1.saudacao());

            System.Console.WriteLine(cpf1.validarCpf()); 
            System.Console.WriteLine(cnpj1.validarCnpj());
            



        }
    }
}
