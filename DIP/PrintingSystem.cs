namespace DIP
{
    public class PrintingSystem
    {
        private IInvoicePrinter _invoicePrinter;

        public PrintingSystem(IInvoicePrinter invoicePrinter)
        {
            _invoicePrinter = invoicePrinter;
        }

        public void Print(Invoice invoice)
        {
            _invoicePrinter.Print(invoice);
        }
    }
}
