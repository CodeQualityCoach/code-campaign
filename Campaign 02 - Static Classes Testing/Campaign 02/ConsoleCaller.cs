using System;

namespace Campaign_02
{
    public class ConsoleCaller
    {
        private readonly IConsole _console;

        public ConsoleCaller(IConsole console)
        {
            _console = console ?? throw new ArgumentNullException(nameof(console));
        }
        public void DoSomething()
        {
            _console.WriteLine("Hello World");
        }

        public void GetSomething()
        {
            var answer = _console.ReadLine();
            _console.WriteLine($"Hello {answer}");
        }
    }
}