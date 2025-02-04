using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite o preço do produto: ");
double produto = Convert.ToDouble(Console.ReadLine());					
Console.Write("Digite o desconto a ser feito: ");
double percentualdesconto = Convert.ToDouble(Console.ReadLine());			
double desconto = produto * (percentualdesconto / 100);
double precofinal = produto - desconto;			
Console.WriteLine();
Console.WriteLine("O desconto foi: " + desconto);
Console.WriteLine("O preço do produto com o desconto aplicado é: " + precofinal);
Console.WriteLine();			
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
