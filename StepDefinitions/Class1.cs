using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    internal class Class1
    {
        [Given(@"B")]
        public void GivenB()
        {
            Console.Write("gIVEN B");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.Write("gIVEN C");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.Write("gIVEN D");
        }

        [Given(@"OPEN CHROME")]
        public void GivenOPENCHROME()
        {
            Console.Write("Open chrome**********");
        }

        [Given(@"OPEN firefox")]
        public void GivenOPENFirefox()
        {
            Console.Write("Open fIREFOX**********");
        }

    }
}
