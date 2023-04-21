using BLL.Interfaces;
using BLL.Services;
using DAL.Models;
using DAL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_LABO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Invoice>> Get()
        {
            return Ok(_invoiceService.GetAll());
        }

        [HttpGet("{id}")]

        public ActionResult<Invoice> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                Invoice? invoice = _invoiceService.GetById(id);
                return invoice is not null ? Ok(invoice) : BadRequest();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteInvoice(int id)
        {
            if (ModelState.IsValid)
            {
                bool invoice = _invoiceService.DeleteInvoice(id);
                return invoice is true ? Ok(invoice) : BadRequest();
            }

            return BadRequest();
        }
    }
}
