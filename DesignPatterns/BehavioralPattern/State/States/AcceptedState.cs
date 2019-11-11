using System;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public class AcceptedState : BaseState
    {
        public AcceptedState(Invoice invoice) : base(invoice)
        {
        }

        public override void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine("Can't add items to accepted invoices.");
        }

        public override void Process()
        {
            Invoice.UpdateState(new PostedState(Invoice));
            Console.WriteLine("State updated to PostedState.");

        }
    }
}