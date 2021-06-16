namespace ISP
{
    public class InvoicePrinter : IInvoicePrinter, ISomeOtherPrint
    {
        public void Print(Invoice invoice)
        {
            //what ever you want
        }

        public void PrintComplex(ComplexInvoice complexInvoice)
        {
            //what ever you want
        }

        public void SomeOtherPrint(Invoice invoice)
        {
            //what ever you want
        }
    }
}
