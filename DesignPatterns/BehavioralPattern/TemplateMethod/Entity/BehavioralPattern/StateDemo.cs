using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.State;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern
{
    public class StateDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var invoice = new Invoice(new List<InvoicePosition>
            {
                new InvoicePosition("PC", 2999),
                new InvoicePosition("Keyboard", 299)
            });

            invoice.Process();
            invoice.AddItem(new InvoicePosition("Mouse", 59));
            invoice.Process();
            invoice.Process();
            invoice.AddItem(new InvoicePosition("Monitor", 799));
            invoice.Process();
            invoice.Process();
        }
    }
}