using DeliverITTestAPI.Helper;
using DeliverITTestAPI.Interface;

namespace DeliverITTestAPI.DTO
{
    public class InsertBillDTO : IBill
    {
        public string NmBill { get; set; } = string.Empty;
        public double VlOriginal { get; set; }
        public DateTime DtDue { get; set; }
        public DateTime DtPayment { get; set; }

    }
}
