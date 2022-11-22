using DeliverITTestAPI.EFC;
using DeliverITTestAPI.Interface;
using DeliverITTestAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DeliverITTestAPI.Service
{
    public class BillService : IBillService
    {
        private readonly ILogger<BillService> _logger;
        private readonly DataContext _dbContext;

        public BillService(ILogger<BillService> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IList<Bill>> GetAllItems()
        {
            List<Bill> billList = await _dbContext.Bills.ToListAsync();

            return billList;
        }

        public async Task InsertItem(Bill bill)
        {
            _dbContext.Bills.Add(bill);
            await _dbContext.SaveChangesAsync();
        }
    }
}
