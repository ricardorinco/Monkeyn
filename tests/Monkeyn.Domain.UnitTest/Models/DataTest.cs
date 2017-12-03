using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using System;
using System.Linq;

namespace Monkeyn.Domain.UnitTest.Models
{
    [TestClass]
    public class DataTest
    {
        #region IsValid
        [TestMethod]
        public void Data_SelfValidation_IsValid()
        {
            var data = new Data
            {
                NumberDiscs = 4,
                InitialDateTime = DateTime.Now,
                FinalDateTime = DateTime.Now.AddMinutes(1)
            };

            var result = data.IsValid();
            
            Assert.IsTrue(result);
        }
        #endregion

        #region IsNoValid
        [TestMethod]
        public void Data_SelfValidation_IsNoValid()
        {
            var data = new Data
            {
                NumberDiscs = 0,
                InitialDateTime = DateTime.Now.AddDays(-10),
                FinalDateTime = DateTime.Now.AddDays(10)
            };

            var result = data.IsValid();

            Assert.IsFalse(result);
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.NumberDiscMustHaveNumberGreaterThanZeroErrorMessage));
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));
            Assert.IsFalse(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));
        }

        [TestMethod]
        public void Data_SelfValidation_Null_IsNoValid()
        {
            var data = new Data { };

            var result = data.IsValid();

            Assert.IsFalse(result);
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.NumberDiscMustHaveNumberGreaterThanZeroErrorMessage));
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.InitialDateTimeMustHaveDateErrorMessage));
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));
            Assert.IsTrue(data.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage));
        }
        #endregion
    }
}
