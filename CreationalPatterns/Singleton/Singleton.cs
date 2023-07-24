namespace DesignPatterns.CreationalPatterns.Singleton;

internal class Singleton : IDesignPattern
{
    public void Main()
    {
        var pacManGame = PacManGame.ExecuteGame();
        Thread.Sleep(3000);
        var pacManGame2 = PacManGame.ExecuteGame();

        pacManGame.ExecutedAt();
        pacManGame2.ExecutedAt();
    }
}
