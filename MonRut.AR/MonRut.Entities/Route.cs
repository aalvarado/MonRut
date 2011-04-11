using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;
using System.Collections.Generic;

namespace MonRut.Domain
{
	[ActiveRecord]
	public class Route : ActiveRecordValidationBase<Route>
	{
        private int id;
        private string name;

		public Route ()
		{
		}

		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
            get { return id; }
            set { id = value; }
		}

        [Property(NotNull = true, Unique = true)]
		[ValidateNonEmpty("No debe de estar vacio")]
        [ValidateIsUnique("Nombre ya existe")]
		public string Name {
            get { return name; }
            set { name = value; }
		}
	}
}

