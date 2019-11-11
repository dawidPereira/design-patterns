using System;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public abstract class BaseState : IInvoiceState
    {
        protected readonly Invoice Invoice;

        protected BaseState(Invoice invoice)
        {
            Invoice = invoice;
        }

        public abstract void AddItem(InvoicePosition invoicePosition);

        public abstract void Process();
    }
}