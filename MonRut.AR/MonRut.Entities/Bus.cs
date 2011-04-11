using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;
using System.Collections.Generic;

namespace MonRut.Domain
{
	[ActiveRecord]
	public class Bus : ActiveRecordValidationBase<Bus>
	{
        private int id;
        private int number;
        private int seats;
        private int capacity;

		public Bus ()
		{
		}

		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
			get{return id;}
            set { id = value; }
		}

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        public int Number
        {
            get;
            set;
        }

		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]
		public int Seats {
			get;
			set;
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int Capacity {
			get;
			set;
		}

	}
}

