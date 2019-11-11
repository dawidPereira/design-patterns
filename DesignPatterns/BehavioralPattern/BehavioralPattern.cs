using DesignPatterns.BehavioralPattern.TemplateMethod.Entity.BehavioralPattern;

namespace DesignPatterns.BehavioralPattern
{
    public class BehavioralPattern : IBehavioralPattern
    {
        private readonly ChainOfResponsibilityDemo _chainOfResponsibilityDemo;
        private readonly IteratorDemo _iteratorDemo;
        private readonly CommandDemo _commandDemo;
        private readonly MediatorDemo _mediatorDemo;
        private readonly MementoDemo _mementoDemo;
        private readonly ObserverDemo _observerDemo;
        private readonly StateDemo _stateDemo;
        private readonly StrategyDemo _strategyDemo;
        private readonly VisitorDemo _visitorDemo;

        public BehavioralPattern()
        {
            _chainOfResponsibilityDemo = new ChainOfResponsibilityDemo();
            _iteratorDemo = new IteratorDemo();
            _commandDemo = new CommandDemo();
            _mediatorDemo = new MediatorDemo();
            _mementoDemo = new MementoDemo();
            _observerDemo = new ObserverDemo();
            _stateDemo = new StateDemo();
            _strategyDemo = new StrategyDemo();
            _visitorDemo = new VisitorDemo();
        }

        public void ShowDemo()
        {
            _chainOfResponsibilityDemo.ShowDemo(DemoName.ChainOfResponsibility);
            _iteratorDemo.ShowDemo(DemoName.Iterator);
            _commandDemo.ShowDemo(DemoName.Command);
            _mediatorDemo.ShowDemo(DemoName.Mediator);
            _mementoDemo.ShowDemo(DemoName.Memento);
            _observerDemo.ShowDemo(DemoName.Observer);
            _stateDemo.ShowDemo(DemoName.State);
            _strategyDemo.ShowDemo(DemoName.Strategy);
            _visitorDemo.ShowDemo(DemoName.Visitor);
        }
    }
}