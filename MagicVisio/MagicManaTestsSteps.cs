using System;
using TechTalk.SpecFlow;
using MagicTheGathering.Models;


namespace MagicVisioTests
{
    

    [Binding]
    public class MagicManaTestsSteps
    {
        [Given(@"I have Started a Game")]
        public void GivenIHaveStartedAGame()
        {
            Game.Start();
        }
        
        [When(@"I Add '(.*)' '(.*)' Mana into the Mana Pool")]
        public void WhenIAddManaIntoTheManaPool(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Mana Request Response Should look like:")]
        public void ThenTheManaRequestResponseShouldLookLike(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
