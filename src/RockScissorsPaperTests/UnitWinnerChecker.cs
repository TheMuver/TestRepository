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
        public void WhenRockandPaperGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Paper);
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void WnenInsertIntegerGotErr()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play((rsp)5, (rsp)9);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void WhenScissorsandScissorsGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Scissors);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenPaperandRockGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Rock);
            Assert.Equal(1, result);
        }
    }
}
