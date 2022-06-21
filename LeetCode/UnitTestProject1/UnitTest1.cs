using System;
using System.Collections.Generic;
using FourSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringCamparsion()
        {
            FourSum.StringCamparsion srCamp = new FourSum.StringCamparsion();
            char ch= srCamp.FindTheDifference("ab", "aba");
            char expected = 'a';
            Assert.AreEqual(expected, ch);
        }

        [TestMethod]
        public void SelfDivideNumber_Success()
        {
            FourSum.SelfDividingNumbersClass srCamp = new FourSum.SelfDividingNumbersClass();
            System.Collections.Generic.IList<int> actual = srCamp.SelfDividingNumbers(1, 22);
            System.Collections.Generic.IList<int> expected = new System.Collections.Generic.List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 };

            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void HeightChecker_Success()
        {
            FourSum.HeightCheckerSolution htCheck = new FourSum.HeightCheckerSolution();
            int expectEdMove = 3;
            int acctalMove = htCheck.HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 });
            Assert.AreEqual(expected: expectEdMove, actual: acctalMove);
        }

        [TestMethod]
        public void GetSubDomain_Visits()
        {
            FourSum.SubdomainVisit sdVisist = new FourSum.SubdomainVisit();
            IList<String> result = sdVisist.SubdomainVisits(new string[] { "9001 discuss.leetcode.com" });
            IList<string> actual = new List<string>()
            {
                "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"
            };
            Assert.AreEqual(result.Count, actual.Count);
        }

        [TestMethod]
        public void GetSubDomain_Visits_Multiple()
        {
            FourSum.SubdomainVisit sdVisist = new FourSum.SubdomainVisit();
            IList<String> result = sdVisist.SubdomainVisits(new string[] {
                "900 google.mail.com", "50 yahoo.com", 
            });
            IList<string> actual = new List<string>()
            {
                 "900 google.mail.com", "50 yahoo.com",  "9000 mail.com", "950 com"
            };
            Assert.AreEqual(result.Count, 4);
        }

        [TestMethod]
        public void GetNumber_SquareRoot()
        {
            FourSum.SquareRoot squareRoot = new SquareRoot();

        }

        [TestMethod]
        public void TestShortestDistance()
        {
            DistanceBetweenBusStops_V1 dist = new DistanceBetweenBusStops_V1();
            int expected = 1;
            Assert.AreEqual(expected, dist.DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 1, 0));
        }

        [TestMethod]
        public void TestShortestDistanceToChar()
        {
            var exp = new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };
            ShortestDistance_ToA_Character sh = new ShortestDistance_ToA_Character();
            var act = sh.ShortestToCHar("loveleetcode", 'e');
            CollectionAssert.AreEqual(act, exp);
        }

        [TestMethod]
        public void TestPlusOneMethod()
        {
            var digits = new int[] { 9, 9, 9 };
            ArrayPlusOne arrayPlusOne = new FourSum.ArrayPlusOne();
            var result =arrayPlusOne.PlusOne(digits);
            var expected = new int[] { 1, 0, 0, 0 };
            CollectionAssert.AreEqual(result, expected);
        }

        /*  [TestMethod]
          public void TestRepeatedElementsInArray()
          {
              int [] numbers = { 1 };
              int[] output = { };
              ArrayReverse arrayReverse = new ArrayReverse();
              var result = arrayReverse.RepeatNumbersInArray(numbers);
              CollectionAssert.AreEqual(output, result);
          }*/

        [TestMethod]
        public void TestReverseString(){
		  string input = "the sky is blue";
		  string expectedResult = "blue is sky the";
          var actualResult = BalancedParenthesis.stringExtensionsLeetCode.ReverseWords(input);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Test_Search_Insert_InArray()
        {
            var input =new int[] { 1, 2, 5, 7 };
            var target = 5 ;
            var arravReverse = new ArrayReverse();
            var result = 2;
            var actualResult = arravReverse.Search(input, target);
            Assert.AreEqual(actualResult, result);
        }
    }
}
