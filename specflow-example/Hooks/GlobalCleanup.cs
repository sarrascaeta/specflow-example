using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specflow_example.Steps;
using TechTalk.SpecFlow;

namespace specflow_example.Hooks
{
    [Binding]

    class GlobalCleanup
    {
        [AfterScenario]
        public static void CleanupDriver()
        {
            Common.driver.Quit();
        }
    }
}
