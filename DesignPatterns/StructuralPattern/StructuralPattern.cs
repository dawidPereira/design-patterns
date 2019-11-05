using DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern;

namespace DesignPatterns.StructuralPattern
{
    public class StructuralPattern :IStructuralPattern
    {
        private readonly AdapterDemo _adapterDemo;
        private readonly BridgeDemo _bridgeDemo;
        private readonly DecoratorDemo _decoratorDemo;
        private readonly FacadeDemo _facadeDemo;
        private readonly FlyweightDemo _flyweightDemo;
        private readonly ProxyDemo _proxyDemo;


        public StructuralPattern()
        {
            _proxyDemo = new ProxyDemo();
            _flyweightDemo = new FlyweightDemo();
            _adapterDemo = new AdapterDemo();
            _bridgeDemo = new BridgeDemo();
            _decoratorDemo = new DecoratorDemo();
            _facadeDemo = new FacadeDemo();
        }

        public void ShowDemo()
        {
            _flyweightDemo.ShowDemo(DemoName.Flyweight);
            _adapterDemo.ShowDemo(DemoName.Adapter);
            _bridgeDemo.ShowDemo(DemoName.Bridge);
            _decoratorDemo.ShowDemo(DemoName.DecoratorDemo);
            _facadeDemo.ShowDemo(DemoName.Facade);
            _proxyDemo.ShowDemo(DemoName.Proxy);
        }
    }
}