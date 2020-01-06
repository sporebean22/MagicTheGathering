using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace MagicTheGathering.Tests
{
    [Binding]
    public class CreatingAJsonFileFromACardSteps
    {
        private Dictionary<TerrainColour, int> ManaCost { get; set; } = new Dictionary<TerrainColour, int>();

        [Given(@"I have created a basic monster with the following ManaCost:")]
        public void GivenIHaveCreatedABasicMonsterWithTheFollowingManaCost(Table table)
        {
            //ManaCost.Add();
        }

        [Given(@"the following propeties:")]
        public void GivenTheFollowingPropeties(Table table)
        {
            //var monster = new Monster(ManaCost, table.Rows[0], table.Rows[1], table.Rows[2], table.Rows[3], table.Rows[4]);

        }

        [When(@"the json file generation is triggered")]
        public void WhenTheJsonFileGenerationIsTriggered()
        {
            
        }

        [Then(@"the file is found in the directory '(.*)' with filename of '(.*)'")]
        public void ThenTheFileIsFoundInTheDirectory(string p0)
        {
            
        }
    }
}
