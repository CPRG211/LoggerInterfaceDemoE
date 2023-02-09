using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoE
{
    /// <summary>
    /// Interface for logger driver
    /// </summary>
    internal interface ILoggerDriver
    {
        /// <summary>
        /// Logs a message
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
