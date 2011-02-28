using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord]
	public class Person
	{
		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
			get;
			set;
		}
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]
		public string FirstName {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string LastName {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int Age {
			get;
			set;
		}
		public Person ()
		{
		}
	}
}

