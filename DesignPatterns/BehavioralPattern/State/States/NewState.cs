using System;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public class NewState : BaseState
    {
        public NewState(Invoice invoice) : base(invoice)
        {
        }

        public override void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine($"Added: {invoicePosition.Name} | ActualPrice: {invoicePosition.Price}.");
            Invoice.ItemList.Add(invoicePosition);
        }

        public override void Process()
        {
            Console.WriteLine("State updated to ReadyForAcceptationState.");
            Invoice.UpdateState(new ReadyForAcceptationState(Invoice));
        }
    }
}