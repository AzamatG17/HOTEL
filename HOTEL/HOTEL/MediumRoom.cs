using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class MediumRoom : Hotel
    {
        private static int[] Rooms = new int[20];
        private Dictionary<int, Quality> medium = new Dictionary <int, Quality>();
        public MediumRoom() { }
        public MediumRoom(int id, int valueRooms, decimal price) : base(id,valueRooms,price)
        {
            RoomsId = id;
            ValueRooms = valueRooms;
            Price = price;
        }
        public override void Display()
        {
            Console.WriteLine(" What you want : ");
            Console.WriteLine(" 1 Book room");
            Console.WriteLine(" 2 Look history rooms ");
            Console.Write(" : ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("\n Write true number 1 or 2 : ");
            }
            if (num == 1)
            {
                AddUser(); 
            }
            else 
            {
                HistoryUser(); 
            }        
                       
        }
        public override void AddUser()
        {
            Console.Write(" Write your name : ");
            string name = Console.ReadLine();
            Console.Write(" How much day you want rand : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write(" Choose room 1-20 : ");
            int roomNum = int.Parse(Console.ReadLine());
            while (!RentRooms(roomNum))
            {
                Console.Write(" This rooom is booked, choose other rooms 1-20 : ");
                roomNum = int.Parse(Console.ReadLine());
            }
            Quality quality = new Quality(name, day, roomNum);
            medium.Add(roomNum - 1, quality);
            Console.WriteLine(" you rand this room");
            Display();
        }
        public override void HistoryUser()
        {
            Console.Write(" Which room you want look 1-20 : ");
            int num = int.Parse(Console.ReadLine());
            while(!(num >= 1 && num <= 20)) 
            {
                Console.Write(" This room don't have. Try again : ");
                num= int.Parse(Console.ReadLine());
            }
           // bool roomBooked = false;
            for (int i = 0; i < medium.Count; i++)
            {
                var item = medium.ElementAt(i).Value;
                if (num == item.NumRoom && item != null)
                {
                    Console.WriteLine($"{item.Name}, Day: {item.Day}, NumRoom: {item.NumRoom}");
                ///    roomBooked = true;
                }
                else
                {
                    Console.WriteLine(" No one has booked this room !!! ");
                }
            }
            //if (!roomBooked)
            //{
            //    Console.WriteLine("No one has booked this room!!!");
            //}
        }
        public override bool RentRooms(int num)
        {
            if (num > 0 && num <= 20)
            {
                if (Rooms[num - 1] == 0) 
                {
                    Rooms[num - 1] = 1;
                    return true;
                }
            }            
            return false;
        }
    }
}
