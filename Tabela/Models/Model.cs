
namespace Calendar.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public List<string> Radios { get; set; }
        public List<int> Counters { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
