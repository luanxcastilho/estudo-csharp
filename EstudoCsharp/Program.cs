using System;
using System.Globalization;

namespace EstudoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Bom tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine("---------------------");

            //printando variaveis isoladas
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("---------------------");

            //printando strings completas
            //placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //interpolacao
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

            Console.WriteLine("---------------------");

            //exercicio de fixacao
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idadeEx = 30;
            int codigo = 5290;
            char generoEx = 'M';
            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.2345667;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idadeEx} anos de idade, código {codigo} e gênero: {generoEx}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");

            string medidaString = medida.ToString("F3", CultureInfo.InvariantCulture);
            Console.WriteLine($"Separador decimal invariant culture: {medidaString}");
        }
    }
}
