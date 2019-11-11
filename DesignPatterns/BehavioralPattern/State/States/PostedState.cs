using System;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public class PostedState : BaseState
    {
        public PostedState(Invoice invoice) : base(invoice)
        {
        }

        public override void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine("Can't add items to posted invoices.");
        }

        public override void Process()
        {
            Console.WriteLine("Can't process posted invoices.");
        }
    }
}