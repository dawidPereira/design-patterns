using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.State.States;

namespace DesignPatterns.BehavioralPattern.State
{
    public class Invoice : IInvoiceState
    {
        private IInvoiceState _state;
        public ICollection<InvoicePosition> ItemList { get; private set; }

        public Invoice(ICollection<InvoicePosition> itemList)
        {
            ItemList = itemList;
            _state = new NewState(this);
        }

        public void UpdateState(IInvoiceState state) => _state = state;

        public void AddItem(InvoicePosition invoicePosition) => _state.AddItem(invoicePosition);

        public void Process() => _state.Process();
    }
}