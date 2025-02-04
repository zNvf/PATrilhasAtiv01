using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();		 				
Console.WriteLine("O tamanho da palavra digitade é: " +palavra.Length);
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
