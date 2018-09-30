using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
	class Program
	{
		static void Main(string[] args)
		{
			int lata1, garrafa1, garrafa2;

			Console.WriteLine("Digite a quantidade de latas de 350 ml");
			lata1 = 350 * Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Digite a quantidade de garrafa de 600 ml");
			garrafa1 = 600 * Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite a quantidade de garrafas de 2 Litros");
			garrafa2 = 2000 * Convert.ToInt32(Console.ReadLine());

			Console.Write("Litros de refrigerante = " + (lata1+garrafa1+garrafa2)/1000+ " Litros");

			if ((lata1 + garrafa1 + garrafa2) % 1000 != 0)
			{
				Console.Write(" e " + (lata1 + garrafa1 + garrafa2) % 1000 + " ml");
			}
			else
			{
				Console.WriteLine();
			}
			Console.Read();
		}
	}
}
