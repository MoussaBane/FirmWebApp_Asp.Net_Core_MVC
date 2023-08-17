using System.ComponentModel.DataAnnotations;

namespace FirmWebApp.Models
{
    public class Machine
    {
        [Key]
        public int Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Layout? Layout { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public bool RunningStatus { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public int? LayoutOid { get; set; }
    }
}
