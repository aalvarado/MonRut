using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord(Table = "Routes")]
	public class Route
	{
		
		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]
		public string Name {
			get;
			set;
		}

		public Route ()
		{
		}
	}
}

