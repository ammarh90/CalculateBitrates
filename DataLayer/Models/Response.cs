namespace CalculateBitrates.DataLayer.Models
{
    public class Response
    {
        public string DeviceName { get; set; }
        public long Rx { get; set; }
        public long Tx { get; set; }
    }
}
