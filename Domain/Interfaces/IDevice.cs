namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IDevice
    {
       string Name { get; set; }
        string Type { get; set; }
        string Description { get; set; }
        string Color { get; set; }
        string Year { get; set; }
        string ToString();
        
        //public void Sound();
        //public void Show();
        //public void Desc();

    }
}
