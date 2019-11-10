using System;

namespace DesignPatterns.BehavioralPattern.State
{
    public class NewInvoiceState : InvoiceState, IInvoiceState
    {
        public NewInvoiceState(Invoice invoice) : base(invoice)
        {
        }

        public void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine($"Added: {invoicePosition.Name} | ActualPrice: {invoicePosition.Price}.");
            Invoice.ItemList.Add(invoicePosition);
        }

        public void Process()
        {
            Console.WriteLine("State updated to ReadyForAcceptationState.");
            Invoice.UpdateState(new ReadyForAcceptationState(Invoice));
        }
    }
}