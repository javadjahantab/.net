using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Hotel
{
    public class RoomModel
{
    public int RoomId { get; private set; }
    public string RoomType { get; private set; }
    public decimal Price { get; private set; }
    public int AvailableQuantity { get; private set; }

    public RoomModel(int roomId, string roomType, decimal price, int availableQuantity)
    {
        RoomId = roomId;
        RoomType = roomType;
        Price = price;
        AvailableQuantity = availableQuantity;
    }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
    }
}

}