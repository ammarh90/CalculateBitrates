using CalculateBitrates.DataLayer.Models;

namespace CalculateBitrates.Api.ServiceInterfaces
{
    public interface INICService
    {
        Task<List<Response>> PrintCalculateBitrates(DeviceInfo deviceInfo);
    }
}
