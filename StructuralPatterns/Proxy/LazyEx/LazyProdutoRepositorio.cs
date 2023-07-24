namespace ProxyPattern.LazyEx;

public class LazyProdutoRepositorio : IProdutoRepositorio
{
    public LazyProdutoRepositorio()
    {
        Console.WriteLine("Abrindo conexao com o banco");
        Thread.Sleep(3000);
    }

    public void GetProduto(int id)
    {
        Thread.Sleep(1500);
    }
}
