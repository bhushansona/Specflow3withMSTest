using System.Threading;
using TechTalk.SpecFlow;

namespace Specflow3Check.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"Getting with delay of '(.*)' seconds")]
        public void GivenGettingWithDelayOfSeconds(int p0)
        {
            Thread.Sleep(p0 * 1000);
        }
        
        [When(@"Something happens for '(.*)' second")]
        public void WhenSomethingHappensForSecond(int p0)
        {
            Thread.Sleep(p0 * 1000);
        }
        
        [Then(@"Executed for '(.*)' seconds")]
        public void ThenExecutedForSeconds(int p0)
        {
            Thread.Sleep(p0 * 1000);
        }
    }
}
