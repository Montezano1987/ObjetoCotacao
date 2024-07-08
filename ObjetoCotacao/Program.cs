using System.Text.Json;
using ObjetosCotacao.Produto;

public class Program
{
    public static async Task Main(string[] args)
    {
        var objetosApple = await ProdutoService.BuscarObjetosApple();
        foreach (var objeto in objetosApple)
        {
            Console.WriteLine($"ID: {objeto.Id}, Nome: {objeto.Name}");
        }

        Console.WriteLine("------------------------------------------------------------------------------------");

        var totalprecos = await ProdutoService.SomarPrecos();
        Console.WriteLine($"total dos preços: {totalprecos}");
        var cotacaodolar = await CotacaoService.BuscarCotacaoDolar();
        var precototaldosprodutosemreal = totalprecos * double.Parse(cotacaodolar.High);
        Console.WriteLine($"total dos preços em real: {precototaldosprodutosemreal:F2}");

        Console.WriteLine("------------------------------------------------------------------------------------");

        var listaDeCapacity = await ProdutoService.BuscarTodosCapacityMaioresQue150GB();
        foreach (var objeto in listaDeCapacity)
        {
            Console.WriteLine($"ID: {objeto.Id}, Nome: {objeto.Name}");
        }
    }
}