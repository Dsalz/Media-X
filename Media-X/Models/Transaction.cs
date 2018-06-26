using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Media_X.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int BuyerId { get; set; }
        public BillboardBuyer Buyer { get; set; }
        public int ApconNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<DayoftheWeek> DaysofTheWeek { get; set; }
        public DateTime TimeRange {get; set;}
        public DateTime BookingDate { get; set; }
        public IEnumerable<Slot> BookedSlots { get; set; }
    }
}