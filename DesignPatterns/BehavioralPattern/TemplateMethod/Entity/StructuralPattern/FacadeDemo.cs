using DesignPatterns.StructuralPattern.Facade;

namespace DesignPatterns.BehavioralPattern.TemplateMethod.Entity.StructuralPattern
{
    public class FacadeDemo : Demo
    {
        protected override void ProcessDemo()
        {
            var logInFacade = new LogInFacade();

            logInFacade.LogIn();
        }
    }
}