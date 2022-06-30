using Microsoft.AspNetCore.Http;

namespace LayheBack_end.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Namae { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ImageUrle { get; set; }
    }
}
