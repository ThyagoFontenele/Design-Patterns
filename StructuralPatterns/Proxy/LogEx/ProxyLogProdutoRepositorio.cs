namespace ProxyPattern.LogEx;

public class ProxyLogProdutoRepositorio : IProdutoRepositorio
{
    private IProdutoRepositorio _produtoRepositorioOriginal;

	public ProxyLogProdutoRepositorio(IProdutoRepositorio produtoRepositorio)
	{
		_produtoRepositorioOriginal = produtoRepositorio;
	}

	public void GetProduto(int id)
	{
        Console.WriteLine($"Pegando produto de Id: {id}");
        _produtoRepositorioOriginal.GetProduto(id);
	}
}
