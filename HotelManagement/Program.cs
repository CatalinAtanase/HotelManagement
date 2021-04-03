using HotelManagement.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<User> users = new List<User>();
            List<Booking> bookings = new List<Booking>();

            //rooms.Add(new Room(1, 1, 1, true, false));
            //rooms.Add(new Room(1, 1, 1, true, false));
            //rooms.Add(new Room(2, 1, 1, true, false));
            //Console.WriteLine(rooms[0].CompareTo(rooms[1]));
            //Console.WriteLine(rooms[0].CompareTo(rooms[2]));

            Dashboard dashboard = new Dashboard(rooms, users, bookings);
            Application.Run(dashboard);
        }
    }
}
