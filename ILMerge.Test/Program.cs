using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactorius.Logging;

namespace ILMerge.Test
{
    class Program
    {
        static ILog Log = LogManager.GetLogger("Refactorius.Test");
        static void Main(string[] args)
        {
            Log.Info("Running.");
        }
    }
}
