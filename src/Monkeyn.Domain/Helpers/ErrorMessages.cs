using System;

namespace Monkeyn.Domain.Helpers
{
    public static class ErrorMessages
    {
        #region Datas
        public static readonly string NumberDiscMustHaveNumberGreaterThanZeroErrorMessage = "O número de Discos devem ser superior a 0 (Zero).";
        public static readonly string InitialDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage = $"A Data e Hora de Inicio deve ser superior ou igual a Data e Hora Atual ({DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} {DateTime.Now.Hour}:{DateTime.Now.Minute}).";
        public static readonly string InitialDateTimeMustHaveDateErrorMessage = "Data e Hora de Inicio devem ser informados.";
        public static readonly string FinalDateTimeMustHaveDateEqualOrGreaterThanCurrentDateErrorMessage = $"A Data e Hora de Finalização deve ser superior ou igual a Data e Hora Atual ({DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} {DateTime.Now.Hour}:{DateTime.Now.Minute}).";
        #endregion

        #region Hanoi
        public static readonly string HanoiMustHaveIdErrorMessage = "O Id da execução deve ser informados.";
        public static readonly string HanoiMustHaveStatusErrorMessage = "O Status da execução deve ser informados.";
        #endregion

        #region Moves
        public static readonly string PinMustHavePinLetterErrorMessage = "O Pino de Hanói deve conter uma Letra.";
        public static readonly string PinMustHavePinLetterValidErrorMessage = $"O Pino de Hanói deve conter uma Letra Valid ('{string.Join(", ", Constants.AcceptedPinLetters)}').";
        #endregion
    }
}
