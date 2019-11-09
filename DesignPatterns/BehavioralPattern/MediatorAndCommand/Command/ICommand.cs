using DesignPatterns.BehavioralPattern.MediatorAndCommand.Mediator;
using DesignPatterns.StructuralPattern.Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.MediatorAndCommand.Command
{
    public interface ICommand
    {
        void SetMediator(IMediator mediator);
    }

    public class AttackCommand : ICommand
    {
        private IMediator _mediator;

        public AttackCommand(MonsterBehavior monsterBehavior)
        {
            MonsterBehavior = monsterBehavior;
        }

        public MonsterBehavior MonsterBehavior{ get; set; }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    public interface ICommandHandler
    {
        void Handle();
    }

    public class FireAttackCommandHandler : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Fireball from FireAttackCommandHandler.");
        }
    }

    public class WatterAttackCommandHandler : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Watterball from WatterAttackCommandHandler.");
        }
    }
}
