using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.models
{
    public interface IPrice
    {
        double getTotalPrice(List<Room> rooms);
    }
}
