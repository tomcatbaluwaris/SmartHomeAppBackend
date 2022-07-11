using SmartHomeBackendTests;

namespace SmartHomeAppBackend;

public class DeviceLogic
{
    public Device[] Devices { get; set; }

    

    public IEnumerable<Device> GetAllDevicesByAreaId(int id)
    {
        return Devices.Where(device => device.Id == id);
    }
}