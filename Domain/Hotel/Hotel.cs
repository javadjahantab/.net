
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Hotel
{
   public class HotelModel
{
    public int HotelId { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string Description { get; private set; }
    public List<RoomModel> Rooms { get; private set; }

    public HotelModel(int hotelId, string name, string address, string description, List<RoomModel> rooms)
    {
        HotelId = hotelId;
        Name = name;
        Address = address;
        Description = description;
        Rooms = rooms;
    }

    public void UpdateDescription(string newDescription)
    {
        Description = newDescription;
    }
}
}

