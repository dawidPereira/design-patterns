using System;
using DesignPatterns.BehavioralPattern.ChainOfResponsibility;
using DesignPatterns.BehavioralPattern.MediatorAndCommand.Command;
using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern;
using DesignPatterns.StructuralPattern.Common.Enum;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderInstance.GetInstance().GetServiceProvider();
            var creationalPatter = serviceProvider.GetService<ICreationalPattern>();
            var structuralPatter = serviceProvider.GetService<IStructuralPattern>();

            //creationalPatter.ShowDemo();
            //structuralPatter.ShowDemo();

            var normalBookingHandler = new NormalBookingHandler();
            var groupBookingHandler = new GroupBookingHandler();
            var specialBookingHandler = new SpecialBookingHandler();

            normalBookingHandler.SetNext(groupBookingHandler);
            groupBookingHandler.SetNext(specialBookingHandler);

            var bookign = new Booking(BookingType.Special);

            normalBookingHandler.Handle(bookign);

            //Mediator and command

            var command = new AttackCommand(MonsterBehavior.Fire);
            var mediator = new Mediator(command);
            mediator.Handle();

            Console.ReadKey();
        }
    }
}
