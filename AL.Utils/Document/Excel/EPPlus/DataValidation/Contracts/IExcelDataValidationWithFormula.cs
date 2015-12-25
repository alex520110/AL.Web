using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AL.Utils.EPPlus.DataValidation.Formulas.Contracts;

namespace AL.Utils.EPPlus.DataValidation.Contracts
{
    public interface IExcelDataValidationWithFormula<T> : IExcelDataValidation
        where T : IExcelDataValidationFormula
    {
        T Formula { get; }
    }
}
