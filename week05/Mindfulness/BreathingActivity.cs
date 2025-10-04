using System;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public override void Run()
        {
            DisplayStartingMessage();

            int elapsed = 0;
            // Simple pattern: breathe in (4s), breathe out (6s) until duration met.
            while (elapsed < _duration)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(4);
                elapsed += 4;
                if (elapsed >= _duration) break;

                Console.WriteLine("Breathe out...");
                ShowCountDown(6);
                elapsed += 6;
            }

            DisplayEndingMessage();
            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadLine();
        }
    }
}
