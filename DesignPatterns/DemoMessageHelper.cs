using System;

namespace DesignPatterns
{
    public static class DemoMessageHelper
    {
        public static void ShowStartDemoMessage(string demoName)
        {
            Console.WriteLine($"Starting {demoName} Demo!");
            Console.WriteLine();
        }

        public static void ShowEndDemoMessage(string demoName)
        {
            Console.WriteLine();
            Console.WriteLine($"Ending {demoName} Demo!");
            ShowSeparator();
            Console.WriteLine();
        }

        public static void ShowSeparator()
        {
            Console.WriteLine("==================================================");
        }
    }
}
