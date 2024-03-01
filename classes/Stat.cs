namespace PulsePortal
{
    public class Stat
    {
        public string? Title { get; set; }
        public int Amount { get; set; }

        public Stat(string name, int number)
        {
            Title = name;
            Amount = number;
        }
    }
}