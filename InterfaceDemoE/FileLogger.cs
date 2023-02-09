using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceDemoE
{
    /// <summary>
    /// Logs messages to files
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 9, 2023</remarks>
    internal class FileLogger : ILoggerDriver
    {
        private string fileNameField;
        private StreamWriter streamWriterField;

        /// <summary>
        /// Constructor for file logger
        /// </summary>
        /// <param name="filename">Filename to write to</param>
        public FileLogger(string filename) { 
            this.fileNameField = filename;
            this.streamWriterField = new StreamWriter(filename);
        }

        public void Log(string message)
        {
            //StreamWriter streamWriterVar;
            //streamWriterVar = File.CreateText(this.fileNameField);

            this.streamWriterField.WriteLine(message);
            this.streamWriterField.Flush();
        }
    }
}
