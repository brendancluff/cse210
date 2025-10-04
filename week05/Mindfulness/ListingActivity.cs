using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _items;
        private Random _random = new Random();

        public ListingActivity()
        {
            _name = "Listing";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _items = new List<string>();
        }

        public override void Run()
        {
            DisplayStartingMessage();

            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"\nList as many responses as you can to the following prompt:\n--- {prompt} ---");
            Console.WriteLine("You will have 5 seconds to prepare.");
            ShowCountDown(5);
            Console.WriteLine($"\nStart listing. You have {_duration} seconds. Press Enter after each item:");

            var sw = Stopwatch.StartNew();
            // NOTE: Console.ReadLine() is blocking. This simpler implementation will allow the user to keep entering lines;
            // if the user is in the middle of typing when time expires, the program will wait for Enter. This keeps the template simple.
            while (sw.Elapsed.TotalSeconds < _duration)
            {
                Console.Write("> ");
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    _items.Add(entry.Trim());
            }

            Console.WriteLine($"\nTime's up! You listed {_items.Count} item(s).");
            if (_items.Count > 0)
            {
                Console.WriteLine("Your items:");
                foreach (var item in _items) Console.WriteLine("- " + item);
            }

            DisplayEndingMessage();
            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadLine();
        }
    }
}
