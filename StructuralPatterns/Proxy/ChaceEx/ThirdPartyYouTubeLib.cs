namespace ProxyPattern.ChaceEx;

public interface ThirdPartyYouTubeLib
{
    IList<int> ListVideos();
    int DownloadVideo(int id);
}
