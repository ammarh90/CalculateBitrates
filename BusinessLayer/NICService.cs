using CalculateBitrates.Api.ServiceInterfaces;
using CalculateBitrates.DataLayer.Models;

namespace CalculateBitrates.BusinessLayer
{
    public class NICService : INICService
    {
        private readonly IBitrateCalculator _calculator;

        public NICService(IBitrateCalculator calculator)
        {
            _calculator = calculator;
        }

        public async Task<List<Response>> PrintCalculateBitrates(DeviceInfo deviceInfo)
        {
            try
            {
                List<Response> response = new();
                foreach (NetworkInterfaceCard nic in deviceInfo.Nic)
                {
                    // Assuming polling rate is 2Hz
                    double pollingRate = 2.0;

                    //parse string to double
                    long rxBytes = long.Parse(nic.Rx);
                    long txBytes = long.Parse(nic.Tx);

                    // Print Rx and Tx values
                    Response temp = new();
                    temp.DeviceName = nic.Description;
                    temp.Rx = _calculator.CalculateBitrate(rxBytes, pollingRate);
                    temp.Tx = _calculator.CalculateBitrate(txBytes, pollingRate);
                    response.Add(temp);
                }
                return await Task.FromResult(response);

            }
            catch (Exception ex)
            {
                throw new Exception("Something is wrong");
            }
        }
    }
}
