﻿using System;
using System.Collections.Generic;
using DesignPatterns.BehavioralPattern.ChainOfResponsibility;
using DesignPatterns.BehavioralPattern.Iterator;
using DesignPatterns.BehavioralPattern.MediatorAndCommand.Command;
using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;
using DesignPatterns.BehavioralPattern.Memento;
using DesignPatterns.BehavioralPattern.Observer;
using DesignPatterns.BehavioralPattern.State;
using DesignPatterns.BehavioralPattern.Strategy;
using DesignPatterns.BehavioralPattern.Visitor;
using DesignPatterns.CreationalPattern.Interface;
using DesignPatterns.CreationalPattern.Singleton;
using DesignPatterns.StructuralPattern;
using DesignPatterns.StructuralPattern.Common.Enum;
using Microsoft.Extensions.DependencyInjection;
using Item = DesignPatterns.BehavioralPattern.Observer.Item;

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

            var booking = new Booking(BookingType.Special);

            normalBookingHandler.Handle(booking);

            //Mediator and command

            var command = new AttackCommand(MonsterBehavior.Fire);
            var mediator = new Mediator(command);
            mediator.Handle();


            // Iterator 
            var runnerCollection = new RunnerCollection
            {
                [0] = new Runner("Johan"),
                [1] = new Runner("Eduardo"),
                [2] = new Runner("Luciel"),
                [3] = new Runner("Bard")
            };

            var runnerIterator = runnerCollection.CreateIterator();

            for (var runner = runnerIterator.First();
                !runnerIterator.IsDone; 
                runner = runnerIterator.Next())
            {
                runner.Greetings(runnerIterator.Current);
            }

            // Memento

            var score = new Score();
            var scoreMemory = new ScoreMemory();

            for (var i = 0; i < 3; i++)
            {
                scoreMemory.Backup(score);
                score.AddPoints();
            }

            Console.WriteLine($"Before Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");
            scoreMemory.Undo(score);
            Console.WriteLine($"After Undo() | Points: {score.Points}, KillingSpree: {score.KillingSpree}, | LooseSpree: {score.LooseSpree}.");

            //Observer

            var item = new Item(299, "Keyboard");
            var subscribers = new List<DiscountSubscriber>
            {
                new DiscountSubscriber("Emanule", item.Price, 0.1),
                new DiscountSubscriber("Jason", item.Price, 0.05),
                new DiscountSubscriber("Somebady", item.Price, 0.25)
            };

            foreach (var discountSubscriber in subscribers)
            {
                item.Attach(discountSubscriber);
            }

            item.UpdatePrice(249);

            //State

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

            //Strategy

            var reader = new Reader(new FifoReadingStrategy());

            var readingList = new List<string>
            {
                "First",
                "Second",
                "Third"
            };

            reader.Read(new List<string>());
            reader.Read(readingList);
            reader.SetStrategy(new LifoReadingStrategy());
            reader.Read(readingList);

            //Visitor

            var productMemory = new ProductMemory();
            productMemory.Attach(new Product("PC", 2999));
            productMemory.Attach(new Product("Car", 29999));
            productMemory.Attach(new Product("Headphone", 99));

            productMemory.Accept(new DiscountPriceVisitor());
            productMemory.Accept(new RegularPriceVisitor());
            productMemory.Accept(new DiscountPriceVisitor());
            productMemory.Accept(new BasePriceVisitor());
            productMemory.Accept(new RegularPriceVisitor());



            Console.ReadKey();
        }
    }
}
