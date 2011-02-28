using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord(Table = "Buses")]
	public class Bus : ActiveRecordValidationBase<Bus>
	{
		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
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
		
		[BelongsTo("DriverId")]
		public Driver Driver {
			get;
			set;
		}
		
	[BelongsTo("RouteId")]		
		public Route Route{
			get;
			set;
		}
		
		public Bus ()
		{
		}
	}
}

