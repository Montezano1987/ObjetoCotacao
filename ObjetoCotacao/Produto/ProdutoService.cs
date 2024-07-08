
using System.Text.Json;


namespace ObjetosCotacao.Produto
{
    public static class ProdutoService
    {
        public static readonly HttpClient _httpClient = new HttpClient();
        public static async Task<List<ProdutoServiceDTO>> BuscarTodosObjetos()
        {
            string url = "https://api.restful-api.dev/objects";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var results = JsonSerializer.Deserialize<List<ProdutoServiceDTO>>(responseBody);

            return results;
        }

        public static async Task<List<ProdutoServiceDTO>> BuscarObjetosApple()
        {
            var objetos = await BuscarTodosObjetos();
            var objetosApple = objetos.Where(p => p.Name.Contains("Apple")).ToList();
            int quantidadeObjetoApple = objetosApple?.Count ?? 0;

            return objetosApple;

        }

        public static async Task<double> SomarPrecos()
        {
            var objetos = await BuscarTodosObjetos();
            var somaPrecos = objetos
                .Where(p => p.Data != null && p.Data.Price.HasValue)
                .Select(p => p.Data.Price.Value)
                .Sum();

            return somaPrecos;
        }

        public static async Task<List<string>> ObterTodasCapacidades()
        {
            var objetos = await BuscarTodosObjetos();
            var listaDeCapacidades = objetos
                .Where(p => p.Data != null && !string.IsNullOrEmpty(p.Data.Capacity))
                .Select(p => p.Data.Capacity)
                .ToList();

            return listaDeCapacidades;
        }

        public static List<string> FiltrarCapacidadesMaioresQue150GB(List<string> capacidades)
        {
            var capacidadesMaioresQue150GB = new List<string>();

            foreach (var capacidade in capacidades)
            {
                var GB = capacidade.Split(' ');
                if (GB.Length > 0 && int.TryParse(GB[0], out int capacity) && capacity > 150)
                {
                    capacidadesMaioresQue150GB.Add(capacidade);
                }
            }

            return capacidadesMaioresQue150GB;
        }

        public static async Task<List<ProdutoServiceDTO>> BuscarTodosCapacityMaioresQue150GB()
        {
            var todasCapacidades = await ObterTodasCapacidades();
            var capacidadesMaioresQue150GB = FiltrarCapacidadesMaioresQue150GB(todasCapacidades);
            var objetos = await BuscarTodosObjetos();
            var resultado = objetos
                .Where(p => p.Data != null && capacidadesMaioresQue150GB.Contains(p.Data.Capacity))
                .ToList();

            return resultado;
        }
    }
}