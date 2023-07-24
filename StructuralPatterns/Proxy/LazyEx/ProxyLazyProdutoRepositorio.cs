namespace ProxyPattern.LazyEx;

public class ProxyLazyProdutoRepositorio : IProdutoRepositorio
{
    private IProdutoRepositorio _produtoRepositorioOriginal;

	public void GetProduto(int id)
	{
        if (_produtoRepositorioOriginal is null)
		{
			_produtoRepositorioOriginal = new LazyProdutoRepositorio();
			_produtoRepositorioOriginal.GetProduto(id);
			return;
		}

        _produtoRepositorioOriginal.GetProduto(id);
	}
}
