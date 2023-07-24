namespace ProxyPattern.LogEx;

public class ProdutoRepositorio : IProdutoRepositorio
{
    public void GetProduto(int id)
    {
        Thread.Sleep(1500);
    }
}
