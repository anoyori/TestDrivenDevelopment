using DeskBooker.Core.Domain;
using System;

namespace DeskBook.Core.DataInterface
{
    public interface IDeskBookingRepository
    {
        void Save(DeskBooking deskBooking);
    }
}
