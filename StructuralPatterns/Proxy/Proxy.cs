using ProxyPattern.LogEx;

namespace DesignPatterns.StructuralPatterns.Proxy;

internal class Proxy : IDesignPattern
{
    public void Main()
    {
        // Exemplo log
        var produtorepositorio = new ProdutoRepositorio();
        var proxyprodutorepositorio = new ProxyLogProdutoRepositorio(produtorepositorio);

        proxyprodutorepositorio.GetProduto(1);
        proxyprodutorepositorio.GetProduto(5);

        //Exemplo Cache
        //var thirdPartyYoutubeClass = new ThirdPartyYouTubeClass();
        //var cachedYoutubeClass = new CachedYoutubeClass(thirdPartyYoutubeClass);

        //Console.WriteLine(cachedYoutubeClass.DownloadVideo(1));
        //Console.WriteLine(cachedYoutubeClass.DownloadVideo(1));
        //Console.WriteLine(cachedYoutubeClass.ListVideos());
        //Console.WriteLine(cachedYoutubeClass.ListVideos());


        //Exemplo Lazy
        //var proxyLazy = new ProxyLazyProdutoRepositorio();
        //proxyLazy.GetProduto(2);
        //proxyLazy.GetProduto(4);

        //Log de encerramento
        Console.WriteLine("Programa finalizado");
    }
}
