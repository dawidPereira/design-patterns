﻿namespace DesignPatterns.CreationalPattern.Singleton
{
    public class SimpleConfiguration
    {
        private static SimpleConfiguration _instance;

        public string FirstValue => "FirstValue";

        public string LastValue => "LastValue";

        private SimpleConfiguration()
        {
            
        }

        public static SimpleConfiguration GetInstance()
        {
            lock (_instance)
            {
                return _instance ?? (_instance = new SimpleConfiguration());
            }
        }
    }
}
