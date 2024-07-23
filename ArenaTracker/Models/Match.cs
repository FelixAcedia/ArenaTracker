namespace ArenaTracker.Models;

public class Match
{
    public Match()
    {
        MatchID = Guid.NewGuid();
    }
    
    public Guid MatchID { get; private set; }
    
    public Fighter[] Participants { get; set; } 
    
    public DateTime Time { get; set; }
}