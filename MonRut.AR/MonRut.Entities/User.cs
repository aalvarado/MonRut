using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;

namespace MonRut.Domain
{
    [ActiveRecord]
    public class User : ActiveRecordValidationBase<User>
    {
        private int id;
        private string name;
        private string hash;
        private bool isAdmin;

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property(NotNull = true,Unique=true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        [ValidateIsUnique("Nombre ya existe")]
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        public string Hash 

        {
            get { return hash; }
            set { hash = value; } 
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        public bool IsAdmin 
        {
            get { return isAdmin; }
            set { isAdmin = value; } 
        }
    }
}
