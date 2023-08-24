using MusicInstrument = ConsoleApp190823.Domain.Models.MusicInstrument;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IOutput<T>
    {
        public void Show(T musicInstrument);

        public void Desc(T musicInstrument);
        public void History(T musicInstrument);
        public void Sound(T musicInstrument);
    }
}
