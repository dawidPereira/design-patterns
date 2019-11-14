using static System.Console;

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
            WriteLine($"Added: {invoicePosition.Name} | ActualPrice: {invoicePosition.Price}.");
            Invoice.UpdateState(new NewState(Invoice));
            WriteLine("State updated to NewState.");
        }

        public override void Process()
        {
            Invoice.UpdateState(new AcceptedState(Invoice));
            WriteLine("State updated to AcceptedState.");
        }
    }
}