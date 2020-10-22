using System.Security.AccessControl;
using System.Net.Cache;
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
        public void WnenInsertIntegerGotErr()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play((rsp)5, (rsp)9);
            Assert.Equal(-1, result);
        }

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

        [Fact]
        public void WhenRockandLizardGotRock()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Lizard);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenRockandSpokeGotSpoke()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Rock, rsp.Spoke);
            Assert.Equal(2, result);
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
        public void WhenScissorsandPaperGotScissors()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Paper);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenScissorsandRockGotRock()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Rock);
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenScissorsandLizardGotScissors()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Lizard);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenScissorsandSpokeGotSpoke()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Scissors, rsp.Spoke);
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

        [Fact]
        public void WhenPaperandLizardGotLizard()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Lizard);
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenPaperandSpokeGotPaper()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Paper, rsp.Spoke);
            Assert.Equal(1, result);
        }
        //EndPaper

        //Lizard
        [Fact]
        public void WhenLizardandRockGotRock()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Lizard, rsp.Rock);
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLizardandPaperGotLizard()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Lizard, rsp.Paper);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenLizardandScissorsGotScissors()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Lizard, rsp.Scissors);
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLizardandSpokeGotLizard()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Lizard, rsp.Spoke);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenLizardandLizardGotDraw()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Lizard, rsp.Lizard);
            Assert.Equal(0, result);
        }
        //endLizard

        //Spoke
        [Fact]
        public void WhenSpokeandRockGotSpoke()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Spoke, rsp.Rock);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenSpokeandPaperGotLizard()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Spoke, rsp.Paper);
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenSpokeandScissorsGotScissors()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Spoke, rsp.Scissors);
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenSpokeandSpokeGotLDraw()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Spoke, rsp.Spoke);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenSpokeandLizardGotDraw()
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(rsp.Spoke, rsp.Lizard);
            Assert.Equal(2, result);
        }
        //endSpoke
    }
}
