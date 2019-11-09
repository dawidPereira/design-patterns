﻿namespace DesignPatterns.BehavioralPattern.ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler handler);

        void Handle(object request);
    }
}
