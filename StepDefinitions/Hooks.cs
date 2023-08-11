using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.Write("Before scenario");
        }

        [AfterScenario]

        public static void AfterAcenario()
        {
            Console.Write("After scenario");
        }

        [BeforeFeature]

        public static void BeforeFeature()
        {
            Console.Write("Before feature");
        }

        [AfterFeature]

        public static void AfterFeature()
        {
            Console.Write("After feature");
        }

        [BeforeScenario("@CategoryA")]

        public static void BeforeScenarioA()
        {
            Console.Write("Before Ctegory A******");
        }

    }
}
