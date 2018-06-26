using System.Collections.Generic;

namespace Media_X.Models
{
    public class Screen
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public OrientationType Orientation { get; set; }
        public IEnumerable<Slot> Slots { get; set; }
        public string Approacg { get; set; }
        public bool HasAudio { get; set; }
        public IEnumerable<VideoFormat> VideoFormats { get; set; }
        public int TrafficCount { get; set; }
        public int TrafficSpeed { get; set; }
        public decimal AnnualRate { get; set; }
    }
}