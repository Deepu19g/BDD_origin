using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    internal class Class2
    {
        [Before]
        public void Setup()
        {
            Console.Write("Before******");
        }
        [After]
        public void Teardown()
        {
            Console.Write("After******");
        }
    }
}
