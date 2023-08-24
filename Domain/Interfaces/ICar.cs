namespace ConsoleApp190823.Domain.Interfaces
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Engine { get; set; }
        string Transmission { get; set; }
        string FuelType { get; set; }
        string MaxSpeed { get; set; }
        string ToString();
        public void Sound();



    }
}
