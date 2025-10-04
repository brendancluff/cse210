using System;
using System.Diagnostics;
using System.Threading;

namespace Mindfulness
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration; // seconds

        protected Activity() { }

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"--- {_name} ---");
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out _duration) || _duration <= 0)
            {
                Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
                _duration = 30;
            }
            Console.WriteLine();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            Console.WriteLine();
            ShowSpinner(2);
        }

        protected void ShowSpinner(int seconds)
        {
            string[] seq = { "/", "-", "\\", "|" };
            var sw = Stopwatch.StartNew();
            int i = 0;
            while (sw.Elapsed.TotalSeconds < seconds)
            {
                Console.Write(seq[i % seq.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
                i++;
            }
        }

        protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.Write("\r");
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}
