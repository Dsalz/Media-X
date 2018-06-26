using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Media_X.Models
{
    public class BillboardBuyer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}