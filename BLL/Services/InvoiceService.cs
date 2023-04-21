using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public bool DeleteInvoice(int id)
        {
            Invoice? invoice = _invoiceRepository.GetById(id);
            if (invoice is not null)
            {

                return _invoiceRepository.DeleteInvoice(invoice);
            }
            return false;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _invoiceRepository.GetAll();
        }

        public Invoice? GetById(int id)
        {
            Invoice? invoice = _invoiceRepository.GetById(id);
            return invoice is not null ? invoice : null;
        }
 
    }
}
