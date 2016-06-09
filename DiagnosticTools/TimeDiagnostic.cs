using System;
using System.Diagnostics;

namespace DiagnosticTools
{
    class TimeDiagnostic
    {
        public static Stopwatch MeasureExecutionTime(Action measuredFunction)
        {
            var sw = new Stopwatch();

            sw.Start();
            measuredFunction();
            sw.Stop();

            return sw;
        }
    }
}
