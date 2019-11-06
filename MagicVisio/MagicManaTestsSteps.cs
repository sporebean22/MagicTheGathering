using TechTalk.SpecFlow;
using System;

namespace MagicVisioTests
{
    [Binding]
    public class MagicManaTestsSteps
    {
        [Given(@"I have Started a Game")]
        public void GivenIHaveStartedAGame()
        {
            throw new NotImplementedException();
        }
        
        [When(@"I Add '(.*)' '(.*)' Mana into the Mana Pool")]
        public void WhenIAddManaIntoTheManaPool(int p0, string p1)
        {
            throw new NotImplementedException();
        }
        
        [Then(@"the Mana Request Response Should look like:")]
        public void ThenTheManaRequestResponseShouldLookLike(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
