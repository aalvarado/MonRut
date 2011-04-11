using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using MonRut.Domain;
using System.Diagnostics;

namespace MonRut.Ws
{
    /// <summary>
    /// Summary description for MonRutWs
    /// </summary>
    [WebService(Namespace = "http://monrut.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MonRutWs : System.Web.Services.WebService
    {
        private bool isObjectSetNull(Object[] objs)
        {
            bool isNull = false;

            foreach (Object item in objs)
            {
                if (item == null)
                {
                    isNull = true;
                    break;
                }
            }
            return isNull;
        }
        // 'Route' methods
        [WebMethod]
        public Route GetRoute(int id)
        {
            Route r = Route.Find(id);
            if (r == null)
            {
                throw new NotFoundException("Route not found: " + id.ToString());
            }
            return r;
        }

        [WebMethod]
        public Route[] GetRouteList(int from, int max)
        {
            Route[] routes = Route.SlicedFindAll(from,max);
            
            return routes;
        }

        [WebMethod]
        public bool AddRoute(string name)
        {
            bool isOperationSuccessful = false;
            Route r = new Route();
            r.Name = name;

            try
            {
                r.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch(Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }
        
        [WebMethod]
        public bool UpdateRoute(int id, string newName)
        {
            bool isOperationSuccessful = false;
            Route r = Route.Find(id);
            if (r != null)
            {
                r.Name = newName;
                try
                {
                    r.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }
        
        [WebMethod]
        public bool DeleteRoute(int id)
        {
            bool isOperationSuccessful = false;
            Route r = Route.Find(id);
            if (r!= null)
            {
                try
                {
                    r.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }
        

        // Driver methods
        [WebMethod]
        public Driver GetDriver(int id)
        {
            Driver d = Driver.Find(id);
            if (d == null)
            {
                throw new NotFoundException("Route not found: " + id.ToString());
            }
            return d;
        }

        [WebMethod]
        public Driver[] GetDriverList(int from, int max)
        {
            Driver[] drivers = Driver.SlicedFindAll(from, max);

            return drivers;
        }

        [WebMethod]
        public bool AddDriver(string firstName, string lastName, int age, int userId)
        {
            bool isOperationSuccessful = false;
            //Route r = new Route();
            //r.Name = name;
            User u = MonRut.Domain.User.Find(userId);
            
            Driver d = new Driver();
            d.FirstName = firstName;
            d.LastName = lastName;
            d.Age = age;
            d.User = u;

            try
            {
                d.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch (Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool UpdateDriver(int id, string firstName,string lastName, int age, int userId)
        {
            bool isOperationSuccessful = false;

            User u = MonRut.Domain.User.Find(userId);
            Driver d = Driver.Find(id);

            if (d != null)
            {
                d.FirstName = firstName;
                d.LastName = lastName;
                d.Age = age;
                d.User = u;
                try
                {
                    d.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }

        [WebMethod]
        public bool DeleteDriver(int id)
        {
            bool isOperationSuccessful = false;
            Driver d = Driver.Find(id);
            if (d != null)
            {
                try
                {
                    d.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }


        // Bus methods
        [WebMethod]
        public Bus GetBus(int id)
        {
            Bus b = Bus.Find(id);
            if (b == null)
            {
                throw new NotFoundException("Route not found: " + id.ToString());
            }
            return b;
        }

        [WebMethod]
        public Bus[] GetBusList(int from, int max)
        {
            Bus[] buses = Bus.SlicedFindAll(from, max);
            return buses;
        }

        [WebMethod]
        public bool AddBus(int number, int capacity)
        {
            bool isOperationSuccessful = false;
            //Route r = new Route();
            //r.Name = name;
            Bus b = new Bus();

            b.Number = number;
            b.Seats = 0;
            b.Capacity = capacity;
            try
            {
                b.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch (Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool UpdateBus(int id, int number, int seats, int capacity)
        {
            bool isOperationSuccessful = false;
            Bus b = Bus.Find(id);
            if (b != null)
            {
                b.Number = number;
                b.Seats = seats;
                b.Capacity = capacity;

                try
                {
                    b.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }

        [WebMethod]
        public bool DeleteBus(int id)
        {
            bool isOperationSuccessful = false;
            Bus b = Bus.Find(id);
            if (b != null)
            {
                try
                {
                    b.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }


        // Station methods
        [WebMethod]
        public Station GetStation(int id)
        {
            Station s = Station.Find(id);
            if (s == null)
            {
                throw new NotFoundException("Route not found: " + id.ToString());
            }
            return s;
        }

        [WebMethod]
        public Station[] GetStationList(int from, int max)
        {
            Station[] stations = Station.SlicedFindAll(from, max);
            return stations;
        }

        [WebMethod]
        public bool AddStation(string name, string city,string district, int zipcode, string state, int number, int routeId)
        {
            bool isOperationSuccessful = false;

            Route r = Route.Find(routeId);
            
            Object[] timeCheckFields = { r };
            
            if (isObjectSetNull(timeCheckFields))
            {
                throw new NotFoundException("Parameters cannot be null");
            }

            Station s = new Station();

            s.Name = name;
            s.City = city;
            s.District = district;
            s.ZipCode = zipcode;
            s.State = state;
            s.Number = number;
            s.Route = r;

            try
            {
                s.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch (Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool UpdateStation(int id, string name, string city, string district, int zipcode, string state, int number,int routeId)
        {
            bool isOperationSuccessful = false;
            Route r = Route.Find(routeId);
            Object[] timeCheckFields = { r };

            if (isObjectSetNull(timeCheckFields))
            {
                throw new NotFoundException("Parameters cannot be null");
            }

            Station s = Station.Find(id);
            if (s != null)
            {
                s.Name = name;
                s.City = city;
                s.District = district;
                s.ZipCode = zipcode;
                s.State = state;
                s.Number = number;
                s.Route = r;

                try
                {
                    s.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }

        [WebMethod]
        public bool DeleteStation(int id)
        {
            bool isOperationSuccessful = false;
            Station s = Station.Find(id);
            if (s != null)
            {
                try
                {
                    s.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }

       
        // TimeCheck methods
        [WebMethod]
        public TimeCheck GetTimeCheck(int id)
        {
            TimeCheck t = TimeCheck.Find(id);
            if (t == null)
            {
                throw new NotFoundException("TimeCheck not found: " + id.ToString());
            }
            return t;
        }

        [WebMethod]
        public bool AddTimeCheck(int driverId, int routeId, int stationId)
        {
            bool isOperationSuccessful = false;
            
            Driver d = Driver.Find(driverId);
            Route r = Route.Find(routeId);
            Station s = Station.Find(stationId);

            Object[] timeCheckFields ={d,r,s};
            if (isObjectSetNull(timeCheckFields))
            {
                throw new NotFoundException("Parameters cannot be null");
            }
            TimeCheck t = new TimeCheck();
            t.Driver = d;
            t.Route = r;
            t.Station = s;
            t.Timestamp = DateTime.Now;

            try
            {
                t.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch (Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool UpdateTimeCheck(int id, int driverId, int routeId, int stationId, DateTime timeStamp)
        {
            bool isOperationSuccessful = false;

            Driver d = Driver.Find(driverId);
            Route r = Route.Find(routeId);
            Station s = Station.Find(stationId);

            Object[] timeCheckFields = {d, r, s };
            if (isObjectSetNull(timeCheckFields))
            {
                throw new NotFoundException("Parameters cannot be null");
            }
            TimeCheck t = TimeCheck.Find(id);
            if (t != null)
            {
                t.Driver = d;
                t.Route = r;
                t.Station = s;
                t.Timestamp = timeStamp;
                
                try
                {
                    t.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool DeleteTimeCheck(int id)
        {
            bool isOperationSuccessful = false;
            TimeCheck t = TimeCheck.Find(id);
            if (t != null)
            {
                try
                {
                    t.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }


        // User methods
        [WebMethod]
        public User GetUser(int id)
        {
            User u = MonRut.Domain.User.Find(id);
            if (u == null)
            {
                throw new NotFoundException("User not found: " + id.ToString());
            }
            return u;
        }

        [WebMethod]
        public User[] GetUserList(int from, int max)
        {
            User[] users = MonRut.Domain.User.SlicedFindAll(from, max);

            return users;
        }

        [WebMethod]
        public bool AddUser(string name, string hash, bool isAdmin)
        {
            bool isOperationSuccessful = false;
            //Route r = new Route();
            //r.Name = name;

            User u = new User();
            u.Name = name;
            u.Hash = hash;
            u.IsAdmin = isAdmin;

            try
            {
                u.SaveAndFlush();
                isOperationSuccessful = true;
            }
            catch (Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);
            }

            return isOperationSuccessful;
        }

        [WebMethod]
        public bool UpdateUser(int id, string name, string hash, bool isAdmin)
        {
            bool isOperationSuccessful = false;
            User u = MonRut.Domain.User.Find(id);
            if (u != null)
            {
                u.Name = name;
                u.Hash = hash;
                u.IsAdmin = isAdmin;
                try
                {
                    u.SaveAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }

        [WebMethod]
        public bool DeleteUser(int id)
        {
            bool isOperationSuccessful = false;
            User u = MonRut.Domain.User.Find(id);
            if (u != null)
            {
                try
                {
                    u.DeleteAndFlush();
                    isOperationSuccessful = true;
                }
                catch (Exception ex)
                {
                    EventLog el = new EventLog();
                    el.Source = "Application";
                    el.WriteEntry(ex.Message);
                }
            }
            return isOperationSuccessful;
        }
    }
}
;