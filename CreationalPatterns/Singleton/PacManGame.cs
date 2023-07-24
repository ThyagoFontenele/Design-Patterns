namespace DesignPatterns.CreationalPatterns.Singleton;

internal class PacManGame
{
    private static PacManGame? game = null;

    private DateTime StartedAt { get; set; }
    
    public void ExecutedAt()
    {
        Console.WriteLine(StartedAt);
    }

    private PacManGame()
    {
        StartedAt = DateTime.Now;
    }

    public static PacManGame ExecuteGame()
    {
        if (game is null)
        {
            game = new PacManGame();
        }

        return game;
    }

    public static void Quit() =>
        game = null;
}
