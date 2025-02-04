using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O número digitado é: " + numero);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
