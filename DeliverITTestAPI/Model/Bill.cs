using DeliverITTestAPI.DTO;
using DeliverITTestAPI.Helper;
using DeliverITTestAPI.Interface;
using System.Text.Json.Serialization;

namespace DeliverITTestAPI.Model
{
    public class Bill : IBill
    {
        public Bill() { }

        public Bill(IBill iBill)
        {
            NmBill = iBill.NmBill;
            VlOriginal = iBill.VlOriginal;
            DtDue = iBill.DtDue;
            DtPayment = iBill.DtPayment;

            VlCorrected = AppHelper.GetCorrectedValue(iBill.VlOriginal, iBill.DtDue, iBill.DtPayment);
            NuDaysLate = AppHelper.GetDayslate(iBill.DtDue, iBill.DtPayment);
        }
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("Nome")]
        public string NmBill { get; set; } = string.Empty;
        [JsonPropertyName("Valor Original")]
        public double VlOriginal { get; set; }
        [JsonIgnore]
        public DateTime DtDue { get; set; }
        [JsonPropertyName("Data De Pagamento")]
        public DateTime DtPayment { get; set; }
        [JsonPropertyName("Valor Corrigido")]
        public double VlCorrected { get; set; }
        [JsonPropertyName("Quantidade de dia em atraso")]
        public int NuDaysLate { get; set; }
    }
}
