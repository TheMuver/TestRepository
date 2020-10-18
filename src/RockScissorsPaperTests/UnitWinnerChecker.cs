using System.Security.Cryptography;
using System.Reflection;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class UnitWinnerChecker
    {
        [Fact]
        public void WhenRockandPaperWinnerPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Paper);
            Assert.Equal(1, result);
        }

        public void WnenInsertInteger()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play((rsp)5, (rsp)9);
            Assert.Edual(-1, result);
        }

        public void WhenScissorsandScissorsDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Scissors);
            Assert.Equal(-1, result);
        }

        public void WhenPaperandRockWinnerPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Rock);
            Assert.Equal(0, result);
        }
    }
}
