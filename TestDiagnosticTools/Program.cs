using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagnosticTools;

namespace TestDiagnosticTools
{
    class TestDiagnosticTools
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                TestExecTime(1000000000);
            }    
            Console.ReadKey();    
        }

        private static void TestExecTime(int count)
        {
            Action func = () =>
            {
                for (int i = 0; i < count; i++)
                {
                    var a = Math.Sqrt(count);
                }
            };

            var diagnos = new DiagnosticResults();
            diagnos.ShowTimeInfoConsole(() => func());           
        }
    }
}
