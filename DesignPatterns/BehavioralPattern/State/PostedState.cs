using System;

namespace DesignPatterns.BehavioralPattern.State
{
    public class PostedState : InvoiceState, IInvoiceState
    {
        public PostedState(Invoice invoice) : base(invoice)
        {
        }

        public void AddItem(InvoicePosition invoicePosition)
        {
            Console.WriteLine("Can't add items to posted invoices.");
        }

        public void Process()
        {
            Console.WriteLine("Can't process posted invoices.");
        }
    }
}