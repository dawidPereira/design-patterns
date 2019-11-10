using System.Collections.Generic;

namespace DesignPatterns.BehavioralPattern.State
{
    public class Invoice : IInvoiceState
    {
        protected IInvoiceState State;
        public ICollection<InvoicePosition> ItemList { get; set; }

        public Invoice(ICollection<InvoicePosition> itemList)
        {
            ItemList = itemList;
            State = new NewInvoiceState(this);
        }

        public void UpdateState(IInvoiceState state)
        {
            State = state;
        }

        public void AddItem(InvoicePosition invoicePosition)
        {
            State.AddItem(invoicePosition);
        }

        public void Process()
        {
            State.Process();
        }
    }
}