using System.Diagnostics;
using System.Timers;
using System.Threading;
using System.Windows;
using Microsoft.VisualBasic;

namespace FocusYouStupid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Prompt;

            System.Timers.Timer timer = new System.Timers.Timer(30000);
            timer.Elapsed += Timer_Elapsed;

            startLoop:
            Prompt = Console.ReadLine();

            if (string.IsNullOrEmpty(Prompt))
            {
                Console.WriteLine($"You Should type 'run' or 'stop' to run, stop the program");
            }
            else
            {
                if (Prompt.ToLower() == "run")
                    timer.Start();
                else if (Prompt.ToLower() == "stop")
                    timer.Stop();
                else
                    Console.WriteLine($"{Prompt} is not a vaild command");
            }
            

            goto startLoop;
        }

        private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Process.Start("I:\\download\\Documents\\AutoHotkey\\FocusYouStupid.ahk");
        }
    }
}
