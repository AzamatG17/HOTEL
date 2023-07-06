using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    abstract class Hotel
    {
        protected int RoomsId { get; set; }
        protected int ValueRooms { get; set; }
        protected decimal Price { get; set; }
        public Hotel() { }
        public Hotel(int id, int valueRooms, decimal price)
        {
            RoomsId = id;
            ValueRooms = valueRooms;
            Price = price;
        }
        public abstract void Display();
        public abstract bool RentRooms(int num);
        public abstract void AddUser();
        public abstract void HistoryUser();
        public abstract void DeleteUser();
        public abstract void Pay(int day);  
    }
}
