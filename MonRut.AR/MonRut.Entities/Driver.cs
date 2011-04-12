using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
	[ActiveRecord]
    [Serializable]
	public class Driver : ActiveRecordValidationBase<Driver>
	{

        private int id;
        private string firstname;
        private string lastname;
        private int age;

        private User user;

        public Driver()
        {
        }

		[PrimaryKey(PrimaryKeyType.Native)]
		public int Id {
            get { return id; }
            set { id = value; }
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]
		public string FirstName {
            get { return firstname; }
            set { firstname = value; }
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public string LastName {
            get { return lastname; }
            set { lastname = value; }
		}
		
		[Property(NotNull = true)]
		[ValidateNonEmpty("No debe de estar vacio")]		
		public int Age {
            get { return age; }
            set { age = value; }
		}

        [BelongsTo("UserId")]
        public User User
        {
            get { return user; }
            set { user = value; }
        }
	}
}

