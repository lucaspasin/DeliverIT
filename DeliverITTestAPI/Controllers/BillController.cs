using DeliverITTestAPI.DTO;
using DeliverITTestAPI.EFC;
using DeliverITTestAPI.Interface;
using DeliverITTestAPI.Model;
using DeliverITTestAPI.Service;
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
        private readonly IBillService _billService;

        public BillController(ILogger<BillController> logger, IBillService billService)
        {
            _logger = logger;
            _billService = billService;
        }

        [HttpPost]
        public async Task<ActionResult<InsertBillDTO>> InsertBill([FromBody] InsertBillDTO billDTO)
        {
            Bill bill = new Bill(billDTO);

            await _billService.InsertItem(bill);

            return Ok(bill);
        }

        [HttpGet]
        public async Task<ActionResult<List<Bill>>> ListBills()
        {
            IList<Bill> billList = await _billService.GetAllItems();

            return Ok(billList);
        }
    }
}
