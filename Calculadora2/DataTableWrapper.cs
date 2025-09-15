using System.Data;

namespace Calculadora2;

public class DataTableWrapper : IDataTableWrapper
{
    public string ComputeExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            throw new ArgumentException("Cannot compute null expressions");
        var result = new DataTable().Compute(expression, null).ToString();

        if (double.TryParse(result, out double convertedDouble)
            && (double.IsInfinity(convertedDouble) || double.IsNaN(convertedDouble)))
        {
            throw new DivideByZeroException();
        }

        return result;
    }
}
