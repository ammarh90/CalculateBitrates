namespace CalculateBitrates.DataLayer.Models
{
    public class DeviceInfo
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NetworkInterfaceCard> Nic { get; set; }
    }
}
