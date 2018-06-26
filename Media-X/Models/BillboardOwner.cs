using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Media_X.Models
{
    public class BillboardOwner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public IEnumerable<Billboard> Billboards { get; set; }
        public string PhoneNumber { get; set; }
        public ClientType ClientType { get; set; }
        public string BankName { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }

    }
}