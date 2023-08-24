using ConsoleApp190823.Domain.Interfaces;
using ConsoleApp190823.Domain.Models;

namespace ConsoleApp190823.Domain.UseCases
{
    public class InstrumentHandler : IOutput<MusicInstrument>
    {
        public void Desc(MusicInstrument musicInstrument)
        {
            musicInstrument.Desc();
        }

        public void History(MusicInstrument musicInstrument)
        {
            musicInstrument.History();
        }

        public void Show(MusicInstrument musicInstrument)
        {
            musicInstrument.Show();
        }

        public void Sound(MusicInstrument musicInstrument)
        {
           musicInstrument.Sound();
        }
    }
}
