using System.Threading;
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
            bbcHome.ClickSportLink()
                   .ClickFootballLink()
                   .ClickTablesLink()
                   .GetTeamInPostion(20);
        }

        [Test]
        public void WhatPositionIsCrystalPalaceInTheLeague()
        {
            
        }
    }
}
