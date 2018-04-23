using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Functions;
using System.Collections.Generic;
using System.Globalization;

namespace CustomFunctionReturningArrayExample {
    #region #TestArrayCustomFunctionImplement
    public class TestArrayCustomFunction : ICustomFunction {
        private string name = "TESTARRAY";
        private ParameterInfo[] parameters = new ParameterInfo[] { new ParameterInfo(ParameterType.Array, ParameterAttributes.Required) };
        private ParameterType return_type = ParameterType.Array;

        public string Name { get { return this.name; } }
        public ParameterInfo[] Parameters { get { return this.parameters; } }
        public ParameterType ReturnType { get { return this.return_type; } }
        public bool Volatile { get { return false; } }
        public string GetName(CultureInfo culture) {
            return Name;
        }
        public ParameterValue Evaluate(IList<ParameterValue> parameters, EvaluationContext context) {
            CellValue[,] args = parameters[0].ArrayValue;
            int xDim = args.GetLength(0);
            int yDim = args.GetLength(1);
            CellValue[,] result = new CellValue[xDim, yDim];

            for (int n = 0; n < args.GetLength(0); n++) {
                for (int m = 0; m < result.GetLength(1); m++) {
                    double coeff = (args[n, m].NumericValue == 0) ? 1 : args[n, m].NumericValue;
                    result[n, m] = (n + 1) * (m + 1) * coeff;
                }
            }

            return result;
        }
    }
    #endregion #TestArrayCustomFunctionImplement
}
