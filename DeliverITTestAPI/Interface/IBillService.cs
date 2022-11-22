using DeliverITTestAPI.Model;

namespace DeliverITTestAPI.Interface
{
    public interface IBillService
    {
        public Task<IList<Bill>> GetAllItems();

        public Task InsertItem(Bill bill);
    }
}
