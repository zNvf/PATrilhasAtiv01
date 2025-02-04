using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite um número decimal : ");
decimal resposta = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("O character é: " + resposta);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
