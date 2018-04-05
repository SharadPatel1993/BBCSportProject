using BBCSportProject.Pages;
using NUnit.Framework;

namespace BBCSportProject.Tests
{
    [TestFixture]
    public class TableTests : TestBase
    {
        private string expected20Team = "West Bromwich Albion";
        private int expectedCpPosition = 17;

        [Test]
        public void WhatTeamIsIn20thPosition()
        {
            var team = new BBCHomePage(Driver).ClickSportLink()
                                          .ClickFootballLink()
                                          .ClickTablesLink()
                                          .GetTeamInPostion(20);
            Assert.AreEqual(team, expected20Team.ToUpper());
        }

        [Test]
        public void WhatPositionIsCrystalPalaceInTheLeague()
        {
            var position = new BBCHomePage(Driver).ClickSportLink()
                                              .ClickFootballLink()
                                              .ClickTablesLink()
                                              .GetTeamPosition("Crystal Palace");
            Assert.AreEqual(position, expectedCpPosition);
        }
    }
}
