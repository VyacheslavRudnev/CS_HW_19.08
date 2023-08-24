namespace ConsoleApp190823.Domain.Interfaces
{
    public interface ITeapot
    {
        string Trademark { get; set; }
        string Material { get; set; }
        string Volume { get; set; }
        string PowerSupply { get; set; }
        string ToString();
        public void Sound();

    }
}
