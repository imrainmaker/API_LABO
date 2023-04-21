using DAL.Models;

namespace DAL.Interfaces
{
    public interface IInvoiceRepository
    {
        public void CreateInvoice(Invoice invoice);

        public void ConfirmInvoice(Invoice invoice);

        public IEnumerable<Invoice> GetAll();

        public Invoice? GetById(int id);

        public Invoice? GetByProduct(int id);

        public bool DeleteInvoice(Invoice invoice);
    }
}
