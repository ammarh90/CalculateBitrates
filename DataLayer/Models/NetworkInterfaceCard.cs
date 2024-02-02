namespace CalculateBitrates.DataLayer.Models
{
    public class NetworkInterfaceCard
    {
        public string Description { get; set; }
        public string Mac { get; set; }
        public DateTime Timestamp { get; set; }
        public string Rx { get; set; }
        public string Tx { get; set; }
    }
}
