using System;
using MonRut.Domain;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System.IO;


namespace MonRut.UI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			Init();
			Console.WriteLine("Deseas crear la DB? (s/n): (s)i");
			string response = Console.ReadLine();
			
			if(response.ToLower() == "s") {
				try{
					ActiveRecordStarter.CreateSchema();
					Console.WriteLine("Estructura de base de datos creada satisfactoriamente");
				}
				catch( Exception ex)
				{
					Console.WriteLine("excepcion" + ex.Message);
				}
			}
			Console.WriteLine("presiona cualquier tecla para continuar");
			Console.ReadLine();
			
		}
		
		private static void Init()
		{
			XmlConfigurationSource arConfig = new XmlConfigurationSource("arconfig.xml");
			
			try{
				
			ActiveRecordStarter.Initialize(arConfig,
			                               typeof(Bus),
			                               typeof(Driver),
			                               typeof(Route),
			                               typeof(Station)
			                               );
			}
			catch( Exception ex)
				{
					Console.WriteLine("excepcion" + ex.Message);
				}
			Console.WriteLine("inicializando...");
			
		}
	}
}

