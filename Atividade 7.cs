using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.WriteLine("Digite seu nome : ");
string nome = Console.ReadLine();	
Console.WriteLine("Digite a idade : ");
int idade = Convert.ToInt32(Console.ReadLine());			
Console.WriteLine();
Console.Write("Seu nome é " + nome );
Console.WriteLine(" e sua idade " + idade);			
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
