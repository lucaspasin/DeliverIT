using DeliverITTestAPI.DTO;
using DeliverITTestAPI.EFC;
using DeliverITTestAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeliverITTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly ILogger<BillController> _logger;
        private readonly DataContext _dbContext;

        public BillController(ILogger<BillController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<InsertBillDTO>> InsertBill([FromBody] InsertBillDTO billDTO)
        {
            try
            {
                Bill bill = new Bill(billDTO);

                _dbContext.Bills.Add(bill);
                await _dbContext.SaveChangesAsync();

                return Ok(bill);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Houve um problema ao inserir, favor tentar novamente" });
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<InsertBillDTO>>> ListBills()
        {
            try
            {
                List<Bill> billList = await _dbContext.Bills.ToListAsync();

                return Ok(billList);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Houve um problema ao buscar as contas, favor tentar novamente" });
            }
        }
    }
}
