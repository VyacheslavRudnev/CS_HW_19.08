using Device = ConsoleApp190823.Domain.Models.Device;
namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IOutput<T>
    {
        public void Show(T device);
        public void Description(T device);
        public void Sound(T device);

    }
}
