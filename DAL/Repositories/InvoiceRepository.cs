using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DataContext _context;

        public InvoiceRepository(DataContext context)
        {
            _context = context;
        }

        public void ConfirmInvoice(Invoice invoice)
        {
            try
            {
                _context.invoices.Update(invoice);
                _context.SaveChanges();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void CreateInvoice(Invoice invoice)
        {
            try
            {
                _context.invoices.Add(invoice);
                _context.SaveChanges();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public bool DeleteInvoice(Invoice invoice)
        {
            try
            {
                _context.invoices.Remove(invoice);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.invoices.ToList();
        }

        public Invoice? GetById(int id)
        {
            try
            {
                return _context.invoices.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Invoice? GetByProduct(int id)
        {
            try
            {
                return _context.invoices.Include(x => x.Product.ProductId == id && x.Status == Enums.InvoiceStatus.Open).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
