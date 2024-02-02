namespace CalculateBitrates.Api.ServiceInterfaces
{
    public interface IBitrateCalculator
    {
        long CalculateBitrate(long bytes, double pollingRate);

    }
}
