using System;
namespace PrimeiraAtividade
{
class Program
{
public static void Main()
{	
Console.Write("Digite seu estado: ");
string estado = Console.ReadLine();		
Console.Write("Digite sua cidade: ");
string cidade = Console.ReadLine();	
Console.Write("Digite sua bairro: ");
string bairro = Console.ReadLine();				
Console.Write("Digite sua rua: ");
string rua = Console.ReadLine(); 			
Console.Write("Digite o número da casa: ");
string casa = Console.ReadLine();		
Console.WriteLine("O seu endereço completo é: " + casa+ ", " + rua +", "+ bairro +"/"+ cidade +" , "+ estado);
Console.WriteLine();
Console.WriteLine("Aperte alguma tecla para fechar...");
Console.ReadKey(true);
}
}
}
