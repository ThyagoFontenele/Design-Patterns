namespace ProxyPattern.ChaceEx;

public class ThirdPartyYouTubeClass : ThirdPartyYouTubeLib
{
    public IList<int> ListVideos()
    {
        Console.WriteLine("Obtendo lista de vídeosS");
        Thread.Sleep(1500);

        return new List<int> { 5, 2, 3};
    }

    public int DownloadVideo(int id)
    {
        Console.WriteLine($"Baixando video de id {id}");
        Thread.Sleep(1500);

        return id;
    }
}
