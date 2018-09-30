using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade33
{
	class Program
	{
		static void Main(string[] args)
		{
			int i,elemento;
			double [] v = new double [15];

			for (i=0;i<15;i++)
			{
				Console.WriteLine("Digite um numero para v["+i+"] :");
				elemento = Convert.ToInt32(Console.ReadLine());

				if (elemento<0)
				{
					v[i] = -1;
				} else
				{
					v[i] = Math.Sqrt(elemento);
				}
			}

			for (i = 0; i < 15; i++)
			{
				Console.WriteLine("v[" + i + "] = " + v[i]);
			}
				Console.Read();

		}
	}
}
