namespace Media_X.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public Screen Screen { get; set; }
        public int ScreenId { get; set; }
        public bool IsBooked { get; set; }
    }
}