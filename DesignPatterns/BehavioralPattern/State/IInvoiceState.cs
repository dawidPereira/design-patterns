namespace DesignPatterns.BehavioralPattern.State
{
    public interface IInvoiceState
    {
        void AddItem(InvoicePosition invoicePosition);
        void Process();
    }
}
