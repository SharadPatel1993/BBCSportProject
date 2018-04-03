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
            var sportHome = new SportHome(Driver);
            sportHome.ClickFootballLink();
            Thread.Sleep(5000); //Debug only
        }

        [Test]
        public void WhatPositionIsCrystalPalaceInTheLeague()
        {
            
        }
    }
}
