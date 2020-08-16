using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsomorphicChecker;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;

namespace IsomorphicChecker.Tests
{
    [TestClass]
    public class IsomorphicCheckerTests
    {
        [DataTestMethod]
        [DataRow("jeden", "dwatysiace")]
        [DataRow("ok", "notOk")]
        public void AreIsomorphicAlways_Should_Fail_WhenParametersDifferAtLenght(string s, string t)
        {
            bool isIsomorphic = IsomorphicChecker.AreIsomorphic(s, t);

            Assert.IsFalse(isIsomorphic);
        }

        [DataTestMethod]
        [DataRow("egg", "add")]
        [DataRow("paper", "title")]
        [DataRow("worek", "palto")]
        [DataRow("meyer", "43831")]
        public void AreIsomorphic_ShouldReturnTrue(string s, string t)
        {

            bool isIsomorphic = IsomorphicChecker.AreIsomorphic(s, t);

            Assert.IsTrue(isIsomorphic);
        }

        [DataTestMethod]
        [DataRow("foo", "bar")]
        [DataRow("mama", "aaaa")]
        [DataRow("grzebien", "grzegrze")]
        [DataRow("abba","abab")]
        public void AreIsomorphic_ShouldReturnFalse(string s, string t)
        {

            bool isIsomorphic = IsomorphicChecker.AreIsomorphic(s, t);

            Assert.IsFalse(isIsomorphic);
        }
    }
}