using System.Security.Cryptography;
using System.Reflection;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class UnitWinnerChecker
    {

        //Rock
        [Fact]
        public void WhenRockandPaperGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Paper);
            Assert.Equal(2, result);
        }

        [Fact]      
        public void WhenRockandRockGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Rock);
            Assert.Equal(0, result);
        }

        [Fact]  
        public void WhenRockandScissorsGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Scissors);
            Assert.Equal(1, result);
        }
        //EndRock

        //Scissors
        [Fact]
        public void WhenScissorsandScissorsGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Scissors);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenScissorsandPaperGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Paper);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenScissorsandRockGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Rock);
            Assert.Equal(2, result);
        }
        //EndScissors

        //Paper
        [Fact]
        public void WhenPaperandPaperGotDraw()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Paper);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenPaperandRockGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Rock);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenPaperandScissorsGotPaper()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Scissors);
            Assert.Equal(2, result);
        }
        //EndPaper

        [Fact]
        public void WnenInsertIntegerGotErr()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play((rsp)5, (rsp)9);
            Assert.Equal(-1, result);
        }
    }
}
