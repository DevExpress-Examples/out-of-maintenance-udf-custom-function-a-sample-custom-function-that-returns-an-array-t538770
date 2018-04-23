using System.Windows;

namespace CustomFunctionReturningArrayExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Ribbon.DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void SpreadsheetControl_Loaded(object sender, RoutedEventArgs e) {
            spreadsheet.CreateNewDocument();
            spreadsheet.ActiveWorksheet.Range["$A$1:$E$2"].FillColor = System.Drawing.Color.Honeydew;

            #region #TestArrayCustomFunctionAdd
            TestArrayCustomFunction customFunction = new TestArrayCustomFunction();
            if (!spreadsheet.Document.Functions.CustomFunctions.Contains(customFunction.Name))
                spreadsheet.Document.Functions.CustomFunctions.Add(customFunction);

            spreadsheet.ActiveWorksheet.Range["$A$4:$E$5"].ArrayFormulaInvariant = "TESTARRAY(A1:E2)";
            spreadsheet.ActiveWorksheet.Range["E7"].Formula = "SUM(TESTARRAY(A1:E2))";
            #endregion #TestArrayCustomFunctionAdd
        }
    }
}
