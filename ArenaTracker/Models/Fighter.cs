namespace ArenaTracker.Models;

public class Fighter
{
    
    public string Name { get; set; }
    
    public int Wins { get; set; }
    public int Loses { get; set; }
    
    public Match[] History { get; set; }
}