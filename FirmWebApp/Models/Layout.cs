using System.ComponentModel.DataAnnotations;

namespace FirmWebApp.Models
{
    public class Layout
    {
        [Key]
        public int Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
