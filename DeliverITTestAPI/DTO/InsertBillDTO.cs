using DeliverITTestAPI.Helper;
using DeliverITTestAPI.Interface;
using System.Text.Json.Serialization;

namespace DeliverITTestAPI.DTO
{
    public class InsertBillDTO : IBill
    {
        [JsonPropertyName("Nome")]
        public string NmBill { get; set; } = string.Empty;
        [JsonPropertyName("Valor Original")]
        public double VlOriginal { get; set; }
        [JsonPropertyName("Data de Vencimento")]
        public DateTime DtDue { get; set; }
        [JsonPropertyName("Data de Pagamento")]
        public DateTime DtPayment { get; set; }

    }
}
