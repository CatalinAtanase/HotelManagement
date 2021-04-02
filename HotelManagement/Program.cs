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

            Dashboard dashboard = new Dashboard(rooms, users, bookings);
            Application.Run(dashboard);
        }
    }
}
