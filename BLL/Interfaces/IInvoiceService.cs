using DAL.Models;

namespace BLL.Interfaces
{
    public interface IInvoiceService
    {
        public IEnumerable<Invoice> GetAll();

        public Invoice? GetById(int id);

        public bool DeleteInvoice(int id);
    }
}
