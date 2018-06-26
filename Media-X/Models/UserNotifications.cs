using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;

namespace Media_X.Models
{
    public class UserNotifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public BillboardOwner User { get; set; }
        public NotificationType Type { get; set; }
        public string Message { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SlotTime { get; set; }
    }
}