using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;

namespace Media_X.Models
{
    public class Billboard
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public BillboardOwner Owner { get; set; }
        public string UniqueId { get; set; }
        public IEnumerable<Screen> Screens { get; set; }
        public BillboardType BillboardType { get; set; }
        public string Address { get; set; }
        public int BillboardStateId { get; set; }
        public State BillboardState { get; set; }
        public int BillboardCityId { get; set; }
        public City BillboardCity { get; set; }
        public string NotableHeritage { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateAdded { get; set; }
    }
    
}