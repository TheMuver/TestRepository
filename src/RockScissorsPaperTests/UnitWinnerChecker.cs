using System.Reflection;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class UnitWinnerChecker
    {
        [Fact]
        public void WhenRockandPaperWinner()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.CheckWinner((rsp)5, (rsp)9);
            Assert.Equal(1, result);
        }
    }
}
