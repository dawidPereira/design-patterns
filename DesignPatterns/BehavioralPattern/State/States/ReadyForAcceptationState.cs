using System;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public class ReadyForAcceptationState : BaseState
    {
        public ReadyForAcceptationState(Invoice invoice) : base(invoice)
        {
        }

        public override void AddItem(InvoicePosition invoicePosition)
        {
            Invoice.ItemList.Add(invoicePosition);
            Console.WriteLine($"Added: {invoicePosition.Name} | ActualPrice: {invoicePosition.Price}.");
            Invoice.UpdateState(new NewState(Invoice));
            Console.WriteLine("State updated to NewState.");

        }

        public override void Process()
        {
            Invoice.UpdateState(new AcceptedState(Invoice));
            Console.WriteLine("State updated to AcceptedState.");
        }
    }
}