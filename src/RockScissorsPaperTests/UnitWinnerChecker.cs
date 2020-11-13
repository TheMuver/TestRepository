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
        public void CallsTests()
        {
            CheckTest(rsp.Rock, rsp.Paper, 2);
        }

        public void CheckTest(rsp player1, rsp player2, int exceptedResult)
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(player1, player2);
            Assert.Equal(exceptedResult, result);
        }

        [Theory]
        [InlineData(rsp.Rock, rsp.Paper, 2)]
        [InlineData(rsp.Rock, rsp.Scissors, 1)]
        [InlineData(rsp.Rock, rsp.Rock, 0)]
        [InlineData(rsp.Paper, rsp.Rock, 1)]
        [InlineData(rsp.Paper, rsp.Scissors, 2)]
        [InlineData(rsp.Paper, rsp.Paper, 0)]
        [InlineData(rsp.Scissors, rsp.Rock, 2)]
        [InlineData(rsp.Scissors, rsp.Paper, 1)]
        [InlineData(rsp.Scissors, rsp.Scissors, 0)]
        public void CheckTestTheory(rsp player1, rsp player2, int exceptedResult)
        {
            AdditionalWinnerChecker winnerChecker = new AdditionalWinnerChecker();
            var result = winnerChecker.Play(player1, player2);
            Assert.Equal(exceptedResult, result);
        }
    }
}
