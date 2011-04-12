using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord]
    [Serializable]
	public class Station : ActiveRecordValidationBase<Station>
	{
        private int id;
        private string name;
        private string city;
        private string district;
        private int zipcode;
        private string state;
        private int number;
        
        private Route route;

        public Station() { }
        
        [PrimaryKey(PrimaryKeyType.Native)]	
		public int Id {
			get{return id;}
			set {id = value;}
		}
        
        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string City {
			get{return city;}
			set{city = value;}
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string District {
			get{return district;} 
			set{district = value;}
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int ZipCode {
			get{return zipcode;}
			set{zipcode = value;}
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string State{
			get{return state;}
			set{state = value;}
		}

		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int Number {
			get{return number;}
			set{number = value;}
		}
        
        [BelongsTo("RouteId")]
        public Route Route
        {
            get { return route; }
            set { route = value; }
        }
		   
	}
}

