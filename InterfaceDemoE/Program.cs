using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceDemoE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoggerDriver logger = new FileLogger("log.txt");
            //ILoggerDriver logger = new TerminalLogger();

            logger.Log("Does something");
            logger.Log("Does something else");
            logger.Log("Does something something else");

            //TerminalLogger terminalLogger = new TerminalLogger();

            //terminalLogger.Log("Does something");
            ////Console.WriteLine("Does something");

            //FileLogger fileLogger = new FileLogger("log.txt");

            ////StreamWriter streamWriterVar;

            ////streamWriterVar = File.CreateText("log.txt");

            ////streamWriterVar.WriteLine("Does something");
            //fileLogger.Log("Does something");

            ////streamWriterVar.Flush();

            //terminalLogger.Log("Does something else");
            ////Console.WriteLine("Does something else");
            ////streamWriterVar.WriteLine("Does something else");

            //fileLogger.Log("Does something else");

            ////streamWriterVar.Flush();

            ////streamWriterVar.Close();
        }
    }
}
