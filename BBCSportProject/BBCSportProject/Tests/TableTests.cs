using BBCSportProject.Pages;
using NUnit.Framework;

namespace BBCSportProject.Tests
{
    [TestFixture]
    public class TableTests : TestBase
    {
        [Test]
        public void WhatTeamIsIn20thPosition()
        {
            var bbcHome = new BBCHome(Driver);
            var team = bbcHome.ClickSportLink()
                              .ClickFootballLink()
                              .ClickTablesLink()
                              .GetTeamInPostion(20).ToUpper();
            Assert.AreEqual(team, "WEST BROMWICH ALBION");
        }

        [Test]
        public void WhatPositionIsCrystalPalaceInTheLeague()
        {
            var bbcHome = new BBCHome(Driver);
            var position = bbcHome.ClickSportLink()
                              .ClickFootballLink()
                              .ClickTablesLink()
                              .GetTeamPosition("Crystal Palace");
            Assert.AreEqual(position, 17);
        }
    }
}
