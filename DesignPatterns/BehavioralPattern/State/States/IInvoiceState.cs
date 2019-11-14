namespace DesignPatterns.BehavioralPattern.State.States
{
    public interface IInvoiceState
    {
        void AddItem(InvoicePosition invoicePosition);
        
        void Process();
    }
}
