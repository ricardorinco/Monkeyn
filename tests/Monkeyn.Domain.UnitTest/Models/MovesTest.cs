using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monkeyn.Domain.Helpers;
using Monkeyn.Domain.Models;
using System.Linq;

namespace Monkeyn.Domain.UnitTest.Models
{
    [TestClass]
    public class MovesTest
    {
        #region IsValid
        [TestMethod]
        public void Move_SelfValidation_A_To_B_IsValid()
        {
            var move = new Move
            {
                FromPin = 'A',
                ToPin = 'B'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Move_SelfValidation_A_To_C_IsValid()
        {
            var move = new Move
            {
                FromPin = 'A',
                ToPin = 'C'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Move_SelfValidation_B_To_A_IsValid()
        {
            var move = new Move
            {
                FromPin = 'B',
                ToPin = 'A'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Move_SelfValidation_B_To_C_IsValid()
        {
            var move = new Move
            {
                FromPin = 'B',
                ToPin = 'C'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Move_SelfValidation_C_To_A_IsValid()
        {
            var move = new Move
            {
                FromPin = 'C',
                ToPin = 'A'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Move_SelfValidation_C_To_B_IsValid()
        {
            var move = new Move
            {
                FromPin = 'C',
                ToPin = 'B'
            };

            var result = move.IsValid();

            Assert.IsTrue(result);
        }
        #endregion

        #region IsValid
        [TestMethod]
        public void Move_SelfValidation_IsNoValid()
        {
            var move = new Move
            {
                FromPin = 'H',
                ToPin = 'T'
            };

            var result = move.IsValid();

            Assert.IsFalse(result);
            Assert.IsTrue(move.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.PinMustHavePinLetterValidErrorMessage));
            Assert.IsTrue(move.ValidationResult.Erros.Count() == 2);
        }

        [TestMethod]
        public void Move_SelfValidation_Null_IsNoValid()
        {
            var move = new Move { };

            var result = move.IsValid();

            Assert.IsFalse(result);
            Assert.IsTrue(move.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.PinMustHavePinLetterErrorMessage));
            Assert.IsTrue(move.ValidationResult.Erros.Any(e => e.Message == ErrorMessages.PinMustHavePinLetterValidErrorMessage));
            Assert.IsTrue(move.ValidationResult.Erros.Count() == 4);
        }
        #endregion
    }
}
