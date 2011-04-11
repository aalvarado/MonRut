using System;
using Castle.ActiveRecord;
using Castle.Components.Validator;
using System.Collections.Generic;

namespace MonRut.Domain
{
    [ActiveRecord]
    public class TimeCheck : ActiveRecordValidationBase<TimeCheck>
    {
        private int id;
        private DateTime timestamp;
        private Driver driver;
        private Route route;
        private Station station;

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property(NotNull = true)]
        [ValidateNonEmpty("No debe de estar vacio")]
        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
       
       
        [ValidateNonEmpty("No debe de estar vacio")]
        [BelongsTo("DriverId")]
        public Driver Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        
     
        [ValidateNonEmpty("No debe de estar vacio")]
        [BelongsTo("RouteId")]
        public Route Route
        {
            get { return route; }
            set { route = value; }
        }
        
        
      
        [ValidateNonEmpty("No debe de estar vacio")]
        [BelongsTo("StationId")]
        public Station Station
        {
            get { return station; }
            set { station = value; }
        }
    }
}