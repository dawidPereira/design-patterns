namespace DesignPatterns.BehavioralPattern.State
{
    public abstract class InvoiceState
    {
        protected readonly Invoice Invoice;

        protected InvoiceState(Invoice invoice)
        {
            Invoice = invoice;
        }
    }
}