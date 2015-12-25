using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AL.Utils.EPPlus.DataValidation.Formulas.Contracts;

namespace AL.Utils.EPPlus.DataValidation.Contracts
{
    /// <summary>
    /// Data validation interface for time validation.
    /// </summary>
    public interface IExcelDataValidationTime : IExcelDataValidationWithFormula2<IExcelDataValidationFormulaTime>, IExcelDataValidationWithOperator
    {
    }
}
