using System;
using System.Runtime.Remoting;

namespace MonRut.Remoting.Server
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("iniciando servicio");
			
			RemotingConfiguration.Configure("Server.exe.config");
			
			Console.WriteLine("Presione ENTER para terminar....");
			Console.ReadLine();
		}
	}
}

