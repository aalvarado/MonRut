using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord(Table = "Stations")]
	public class Station
	{
		
		[PrimaryKey(PrimaryKeyType.Native)]	
		public int Id {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string City {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string District {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int ZipCode {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string State{
			get;
			set;
		}

		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int Number {
			get;
			set;
		}
		
		public Station ()
		{
		}
	}
}

