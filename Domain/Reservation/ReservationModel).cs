using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Reservation
{
public class ReservationModel
{
    public int ReservationId { get; private set; }
    public CustomerModel Customer { get; private set; }
    public HotelModel Hotel { get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime CheckOutDate { get; private set; }
    public List<RoomModel> Rooms { get; private set; }
    public bool IsPaymentConfirmed { get; private set; }

    public ReservationModel(int reservationId, CustomerModel customer, HotelModel hotel, DateTime checkInDate, DateTime checkOutDate, List<RoomModel> rooms, bool isPaymentConfirmed)
    {
        ReservationId = reservationId;
        Customer = customer;
        Hotel = hotel;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Rooms = rooms;
        IsPaymentConfirmed = isPaymentConfirmed;
    }

    public void ConfirmPayment()
    {
      
        IsPaymentConfirmed = true;
    }
}

}