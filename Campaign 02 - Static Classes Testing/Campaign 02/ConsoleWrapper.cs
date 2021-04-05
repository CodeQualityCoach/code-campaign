using System;

namespace Campaign_02
{
    public class ConsoleWrapper : IConsole
    {
        public void WriteLine(string output)
        {
            // it is important to only call the function without any additional logic
            Console.WriteLine(output);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}