using static System.Console;

namespace DesignPatterns.BehavioralPattern.State.States
{
    public class AcceptedState : BaseState
    {
        public AcceptedState(Invoice invoice) : base(invoice)
        {
        }

        public override void AddItem(InvoicePosition invoicePosition) => WriteLine("Can't add items to accepted invoices.");

        public override void Process()
        {
            Invoice.UpdateState(new PostedState(Invoice));
            WriteLine("State updated to PostedState.");
        }
    }
}