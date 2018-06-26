using System.Collections.Generic;

namespace Media_X.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
    
}