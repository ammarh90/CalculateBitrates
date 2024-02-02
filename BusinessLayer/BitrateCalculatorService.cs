using CalculateBitrates.Api.ServiceInterfaces;

namespace CalculateBitrates.BusinessLayer
{
    public class BitrateCalculatorService : IBitrateCalculator
    {
        public long CalculateBitrate(long bytes, double pollingRate)
        {
            //1 byte = 8 bits
            //3698574500 * 8 bits = 2317220640 bits
            //Bitrate = (data size in bits) *(polling rate)
            //Bitrate for Tx = 122558800 / 2 = xxxxx bps

            return (long)(bytes * 8 * pollingRate);
        }
    }
}
