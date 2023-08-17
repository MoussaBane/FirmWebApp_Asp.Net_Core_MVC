namespace FirmWebApp.Models
{
    public class MachineLayoutViewModel
    {
        public Machine MachineModel { get; set; }
        public List<Machine>? ListOfMachines { get; set; }
        public List<Layout> ListOfLayouts { get; set; }
    }
}
