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
            rooms.Add(new Room(1, 1, 100, true, false));
            rooms.Add(new Room(2, 1, 100, true, true));

            List<User> users = new List<User>();
            users.Add(new User("Catalin", "Atanase", "1991031151234", "mail@mail.com", "0712345678"));
            users.Add(new User("claudia", "apostol", "2991031151234", "mail@mail.com", "0712345678"));

            List<Booking> bookings = new List<Booking>();
            bookings.Add(new Booking(users[0], rooms[0], DateTime.Now.ToLocalTime(), DateTime.Now.AddDays(2).ToLocalTime()));
            bookings.Add(new Booking(users[1], rooms[1], DateTime.Now.ToLocalTime(), DateTime.Now.AddDays(2).ToLocalTime()));

            Dashboard dashboard = new Dashboard(rooms, users, bookings);
            Application.Run(dashboard);
        }
    }
}
