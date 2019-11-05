﻿namespace DesignPatterns.StructuralPattern.Facade
{
    public class LoginFacade
    {
        private readonly CheckingService _checkingService;
        private readonly LogicService _logicService;
        private readonly CallThePoliceService _callThePoliceService;

        public LoginFacade()
        {
            _checkingService = new CheckingService();
            _logicService = new LogicService();
            _callThePoliceService = new CallThePoliceService();
        }

        public void LogIn()
        {
            _logicService.StartProcess();
            _checkingService.CheckUserName();
            _checkingService.CheckPassword();
            _checkingService.CheckStatus();
            _logicService.ConfirmProcess();
            _callThePoliceService.CallThePolice();
            _logicService.EndProcess();
        }
    }
}
