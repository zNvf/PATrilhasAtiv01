using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite caracter : ");
char resposta = Console.ReadKey().KeyChar;
Console.WriteLine();
Console.WriteLine("O character é: " + resposta);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
