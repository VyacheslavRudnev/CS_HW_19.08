using ConsoleApp190823.Domain.Interfaces;
using Device = ConsoleApp190823.Domain.Models.Device;

namespace ConsoleApp190823.Domain.UseCases
{
    public class DeviceHandler : IOutput<Device>
    {
        public virtual void Show(Device device)
        {
            device.Show();
        }
        public virtual void Description(Device device)
        {
            device.Desc();
        }
        public virtual void Sound(Device device)
        {
           device.Sound();
        }
    }
}
