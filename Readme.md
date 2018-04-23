# UDF (Custom Function) - A sample custom function that returns an array


This example implements a custom function (UDF) that returns an array. The <strong>TESTARRAY</strong> function gets a range of cells, multiplies relative indexes of a cell in the range by the cell value and returns the resulting array.<br>To display the result in cells, each cell should contain an array formula with that function. To insert an array formula, the example uses the cell's <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_ArrayFormulaInvarianttopic">ArrayFormulaInvariant</a> property.<br>You can insert array formulas using the SpreadsheetControl UI: select a range for the output array, enter a formula, and press <strong>Ctrl+Shift+Enter</strong>.

<br/>


