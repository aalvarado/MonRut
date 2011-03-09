using System;
using System.Runtime.Remoting;
using MonRut.Remoting.Server;

namespace MonRut.Remoting.Client
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Cliente de remoting!");
			RemotingConfiguration.Configure("RemotingClient.config");
			
			RemotingServer server = new RemotingServer();
			
			
			bool shouldExit = false;
			try{
				Console.WriteLine(String.Format("call {0}", server.GetActiveDomain()));
				
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
			
		}
	}
}

