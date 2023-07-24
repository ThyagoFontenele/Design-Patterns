namespace ProxyPattern.ChaceEx;

public class CachedYoutubeClass : ThirdPartyYouTubeLib
{
    private ThirdPartyYouTubeLib originalService;
	private IList<int>? videoList;
	private int? videoDownloaded;

	public CachedYoutubeClass(ThirdPartyYouTubeLib thirdPartyYouTubeLib)
	{
		this.originalService = thirdPartyYouTubeLib;
	}

	public IList<int> ListVideos()
	{
		if (videoList is null)
		{
			videoList = originalService.ListVideos();
			return videoList;
		}

		return videoList;
	}

	public int DownloadVideo(int id)
	{
		if (videoDownloaded is null || videoDownloaded != id)
		{
			videoDownloaded = originalService.DownloadVideo(id);
			return videoDownloaded.Value;
		}

		return videoDownloaded.Value;
	}
}
