using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoE
{
    /// <summary>
    /// Logger driver for terminal
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 9, 2023</remarks>
    internal class TerminalLogger : ILoggerDriver
    {
        /// <summary>
        /// No-arg constructor for terminal logger
        /// </summary>
        public TerminalLogger() { }

        public void Log(string message) { 
            Console.WriteLine(message);
        }
    }
}
