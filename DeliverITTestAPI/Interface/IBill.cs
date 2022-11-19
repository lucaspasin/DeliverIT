namespace DeliverITTestAPI.Interface
{
    public interface IBill
    {
        public string NmBill { get; set; }
        public double VlOriginal { get; set; }
        public DateTime DtDue { get; set; }
        public DateTime DtPayment { get; set; }
    }
}
