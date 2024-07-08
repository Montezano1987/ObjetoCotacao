
using System.Text.Json.Serialization;

namespace ObjetosCotacao.Cotacao
{

    public class BTCBRL
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("codein")]
        public string Codein { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("high")]
        public string High { get; set; }

        [JsonPropertyName("low")]
        public string Low { get; set; }

        [JsonPropertyName("varBid")]
        public string VarBid { get; set; }

        [JsonPropertyName("pctChange")]
        public string PctChange { get; set; }

        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        [JsonPropertyName("ask")]
        public string Ask { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }
    }

    public class EURBRL
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("codein")]
        public string Codein { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("high")]
        public string High { get; set; }

        [JsonPropertyName("low")]
        public string Low { get; set; }

        [JsonPropertyName("varBid")]
        public string VarBid { get; set; }

        [JsonPropertyName("pctChange")]
        public string PctChange { get; set; }

        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        [JsonPropertyName("ask")]
        public string Ask { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }
    }

    public class CotacaoDTO
    {
        [JsonPropertyName("USDBRL")]
        public USDBRL USDBRL { get; set; }

        [JsonPropertyName("EURBRL")]
        public EURBRL EURBRL { get; set; }

        [JsonPropertyName("BTCBRL")]
        public BTCBRL BTCBRL { get; set; }
    }

    public class USDBRL
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("codein")]
        public string Codein { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("high")]
        public string High { get; set; }

        [JsonPropertyName("low")]
        public string Low { get; set; }

        [JsonPropertyName("varBid")]
        public string VarBid { get; set; }

        [JsonPropertyName("pctChange")]
        public string PctChange { get; set; }

        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        [JsonPropertyName("ask")]
        public string Ask { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }
    }
}