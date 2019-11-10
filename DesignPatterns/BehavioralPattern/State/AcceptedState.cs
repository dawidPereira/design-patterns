using System;

namespace DesignPatterns.BehavioralPattern.State
{
    public class AcceptedState : InvoiceState, IInvoiceState
    {
        public AcceptedState(Invoice invoice) : base(invoice)
        {
        }

        public void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine("Can't add items to accepted invoices.");
        }

        public void Process()
        {
            Invoice.UpdateState(new PostedState(Invoice));
            Console.WriteLine("State updated to PostedState.");

        }
    }
}