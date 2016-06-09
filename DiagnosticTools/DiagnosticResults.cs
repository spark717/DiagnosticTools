using System;
using System.Diagnostics;


namespace DiagnosticTools
{
    public class DiagnosticResults
    {
        public void ShowTimeInfoConsole(Action func)
        {
            var result = TimeDiagnostic.MeasureExecutionTime(func);
            Console.WriteLine(result.ElapsedMilliseconds + "ms");
        }
    }
}
