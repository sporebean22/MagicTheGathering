using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using Gherkin.Ast;
using TechTalk.SpecFlow.Assist;
using MagicTheGathering.Models;

namespace MagicTheGathering.Tests
{
    [Binding]
    public class CreatingAJsonFileFromACardSteps
    {
        private INarrator _narrator = new Narrator();
        private Dictionary<TerrainColour, int> ManaCost { get; set; } = new Dictionary<TerrainColour, int>();

        [Given(@"I have created a basic monster with the following ManaCost:")]
        public void GivenIHaveCreatedABasicMonsterWithTheFollowingManaCost(Table table)
        {
            ManaCost = table.CreateInstance<Dictionary<TerrainColour, int>>();
            Console.WriteLine(_narrator.TranslateMana(ManaCost));
        }

        [Given(@"the following propeties:")]
        public void GivenTheFollowingPropeties(Table table)
        {
            //DataTable dt = new DataTable(table);

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
