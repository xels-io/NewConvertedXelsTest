using System;
using System.Collections.Generic;
using System.Linq;
using Xels.SmartContracts.CLR.Validation;
using Xels.SmartContracts.Core.Exceptions;

namespace Xels.SmartContracts.CLR.Exceptions
{
    /// <summary>
    /// Exception that is raised when validation of the contract execution code fails.
    /// </summary>
    /// <remarks>TODO: We can possibly merge this with <see cref="SmartContractValidationResult"/>.</remarks>
    public sealed class SmartContractValidationException : SmartContractException
    {
        public override string Message
        {
            get
            {
                return base.Message + Environment.NewLine + string.Join(Environment.NewLine, this.Errors.Select(x=> x.Message));
            }
        }
        public IEnumerable<ValidationResult> Errors;

        public SmartContractValidationException(IEnumerable<ValidationResult> errors)
        {
            this.Errors = errors;
        }
    }
}