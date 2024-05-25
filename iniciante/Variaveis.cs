using System;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando uma variável do tipo int (inteiro)
            int Idade = 18;
            Idade = 18; // Atribuindo valor 18 à variável Idade
            Console.WriteLine(Idade); // Exibindo o valor da variável Idade

            Idade = 20; // Alterando o valor da variável Idade para 20
            Console.WriteLine(Idade); // Exibindo o novo valor da variável Idade

            // Declarando uma variável do tipo string (texto)
            string NomeCompleto = "Rafael Cardoso";
            Console.WriteLine("Rafael Cardoso"); // Exibindo um texto literal
            Console.WriteLine(NomeCompleto); // Exibindo o valor da variável NomeCompleto

            NomeCompleto = "Joana Martins"; // Alterando o valor da variável NomeCompleto
            Console.WriteLine(NomeCompleto); // Exibindo o novo valor da variável NomeCompleto

            // Comentário: A linha abaixo causaria um erro, pois o valor 10000 é muito grande para o tipo byte
            // byte b = 10000;

            // Utilizando a palavra-chave var para declaração implícita de variáveis
            var Salario = 10000; // O compilador infere que Salario é do tipo int
            var NomeDaMae = "Joana"; // O compilador infere que NomeDaMae é do tipo string
            // Comentário: A linha abaixo causaria um erro, pois NomeDaMae é do tipo string e não pode ser atribuído um valor int
            // NomeDaMae = 10000;

            // Declarando e inicializando uma variável do tipo DateTime
            DateTime DataDeNascimento = new DateTime(1988, 7, 10, 7, 15, 10);
            Console.WriteLine(DataDeNascimento.Year); // Exibindo o ano da data de nascimento
            Console.WriteLine(DataDeNascimento.Month); // Exibindo o mês da data de nascimento
            Console.WriteLine(DataDeNascimento.Day); // Exibindo o dia da data de nascimento
            Console.WriteLine(DataDeNascimento.Hour); // Exibindo a hora da data de nascimento
            Console.WriteLine(DataDeNascimento.Minute); // Exibindo o minuto da data de nascimento
            Console.WriteLine(DataDeNascimento.Second); // Exibindo o segundo da data de nascimento

            // Conversão de string para int
            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);
            Console.WriteLine(NumeroDaCasaInt); // Exibindo o valor convertido de string para int

            // Conversão de int para string
            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);
            Console.WriteLine(NumeroDaCasa2); // Exibindo o valor convertido de int para string

            // Conversão de byte para char utilizando a tabela ASCII
            byte b = 50;
            char c = Convert.ToChar(b); // Converte o valor byte para char
            Console.WriteLine(c); // Exibindo o caractere correspondente ao valor ASCII

            // Conversão de char para int (valor ASCII)
            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC); // Exibindo o valor int correspondente ao caractere

            // Declarando uma variável do tipo double (número com ponto flutuante)
            double d = 1.3;
            Console.WriteLine(d); // Exibindo o valor da variável double

            // Conversão de double para int (note que isso pode truncar o valor decimal)
            int conversaoDoDouble = Convert.ToInt32(d);
            Console.WriteLine(conversaoDoDouble); // Exibindo o valor convertido de double para int

            // Comentário: As linhas abaixo causariam um erro, pois o valor 1000 é muito grande para uma variável do tipo byte
            // int NumeroGrande = 1000;
            // byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            // Console.WriteLine(NumeroPequeno);

            // Aguarda uma tecla ser pressionada antes de fechar o console
            Console.ReadKey();
        }
    }
}
