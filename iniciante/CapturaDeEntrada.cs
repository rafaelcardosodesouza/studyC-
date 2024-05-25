using System;

public class CapturaDeEntrada
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário que digite um número
        Console.WriteLine("Digite um número: ");
        
        // Lê a entrada do usuário, converte de string para int e armazena na variável 'numero'
        int numero = Convert.ToInt32(Console.ReadLine());
        
        // Exibe o número digitado pelo usuário
        Console.WriteLine("O número digitado foi: " + numero);
        
        // Captura a tecla pressionada pelo usuário sem exibi-la no console
        char teclaTeclada = Console.ReadKey(true).KeyChar;
        
        // Exibe a tecla que foi pressionada pelo usuário
        Console.WriteLine("A tecla pressionada foi: " + teclaTeclada);
    }
}
