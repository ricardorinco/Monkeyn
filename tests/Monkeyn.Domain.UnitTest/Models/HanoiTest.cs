using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using System;
using System.Linq;

namespace Monkeyn.Domain.UnitTest.Models
{
    [TestClass]
    public class HanoiTest
    {
        #region IsValid
        [TestMethod]
        public void Data_SelfValidation_IsValid()
        {
            var hanoi = new Hanoi
            {
                Id = Guid.NewGuid(),
                Status = "Finished"
            };

            var result = hanoi.IsValid();

            Assert.IsTrue(result);
        }
        #endregion

        #region IsValid
        [TestMethod]
        public void Data_SelfValidation_Null_IsNoValid()
        {
            var hanoi = new Hanoi { };

            var result = hanoi.IsValid();

            Assert.IsFalse(result);
            Assert.IsTrue(hanoi.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.HanoiMustHaveStatusErrorMessage));
        }
        #endregion
    }
}
