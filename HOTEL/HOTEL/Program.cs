using System.Security.Cryptography;

namespace HOTEL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Yoo Helooo !!! ");
            Start();
        }
        static void Start() 
        {
            Console.WriteLine(" Chose rooms : ");
            Console.WriteLine(" 1 Expensiv rooms ");
            Console.WriteLine(" 2 Mediun rooms ");
            Console.WriteLine(" 3 Cheap rooms ");
            Console.Write(" : ");
            int choseRooms;//= int.Parse(Console.ReadLine());
            while(!(int.TryParse(Console.ReadLine(), out choseRooms) && (choseRooms >= 1 && choseRooms <= 3)))
            {
                Console.WriteLine(" Try again !!!");
                Start();
            }
            switch (choseRooms)
            {
                case 1:
                    // Do something for expensive rooms
                    break;
                case 2:
                  ///  List<Quality> product = new List<Quality>() { };
                    MediumRoom mediumRooms = new MediumRoom();
                    mediumRooms.Display();
                    break;
                case 3:
                    // Do something for cheap rooms
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
}
}