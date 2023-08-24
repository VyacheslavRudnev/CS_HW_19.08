namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IMicrowave
    {
        string Trademark { get; set; }
        string Power { get; set; }
        string ToString();

        public void Sound();
        
        
       


    }
}
