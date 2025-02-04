using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite \"sim\" ou \"não\": ");
string resposta = Console.ReadLine().ToLower();
bool valor = false;			
if (resposta == "sim"){
valor = true;
}
Console.WriteLine();
Console.WriteLine("O valor digitado é: " + valor);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
