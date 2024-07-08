using System.Globalization;
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

        CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
        CultureInfo culturaAmericana = new CultureInfo("en-US");
        var totalprecos = await ProdutoService.SomarPrecos();
        Console.WriteLine($"Total dos preços: {totalprecos.ToString("f2", culturaBrasileira)}");
        var cotacaodolar = await CotacaoService.BuscarCotacaoDolar();
        var valorHigh = double.Parse(cotacaodolar.High, culturaAmericana);
        var precototaldosprodutosemreal = totalprecos * valorHigh;
        Console.WriteLine($"Total dos preços em real: {precototaldosprodutosemreal.ToString("f2",culturaBrasileira)}");

        Console.WriteLine("------------------------------------------------------------------------------------");

        var listaDeCapacity = await ProdutoService.BuscarTodosCapacityMaioresQue150GB();
        foreach (var objeto in listaDeCapacity)
        {
            Console.WriteLine($"ID: {objeto.Id}, Nome: {objeto.Name}");
        }
    }
}