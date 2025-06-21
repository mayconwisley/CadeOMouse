using System;
using System.Diagnostics;
using System.IO;

namespace CadeOMouse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("Nenhum parâmetro de inicialização informado");
				Console.ReadKey();
				return;
			}

			if (args.Length > 1)
			{
				Console.WriteLine("Informar apenas um parâmetro de inicialização");
				Console.ReadKey();
				return;
			}

			string caminhoArquivo = args[0];

			if (!File.Exists(caminhoArquivo))
			{
				Console.WriteLine("Arquivo não encontrado.");
				Console.ReadKey();
				return;
			}

			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = caminhoArquivo,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro ao abrir o arquivo: {ex.Message}");
				Console.ReadKey();
			}
		}
	}
}
