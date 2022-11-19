using DeliverITTestAPI.DTO;
using DeliverITTestAPI.Helper;
using DeliverITTestAPI.Interface;

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

        public int Id { get; set; }
        public string NmBill { get; set; } = string.Empty;
        public double VlOriginal { get; set; }
        public DateTime DtDue { get; set; }
        public DateTime DtPayment { get; set; }
        public double VlCorrected { get; set; }
        public int NuDaysLate { get; set; }
    }
}
