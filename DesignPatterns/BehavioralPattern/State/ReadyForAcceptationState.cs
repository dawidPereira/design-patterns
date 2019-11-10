using System;

namespace DesignPatterns.BehavioralPattern.State
{
    public class ReadyForAcceptationState : InvoiceState, IInvoiceState
    {
        public ReadyForAcceptationState(Invoice invoice) : base(invoice)
        {
        }

        public void AddItem(InvoicePosition invoicePosition)
        {
            Invoice.ItemList.Add(invoicePosition);
            Console.WriteLine($"Added: {invoicePosition.Name} | ActualPrice: {invoicePosition.Price}.");
            Invoice.UpdateState(new NewInvoiceState(Invoice));
            Console.WriteLine("State updated to NewInvoiceState.");

        }

        public void Process()
        {
            Invoice.UpdateState(new AcceptedState(Invoice));
            Console.WriteLine("State updated to AcceptedState.");
        }
    }
}