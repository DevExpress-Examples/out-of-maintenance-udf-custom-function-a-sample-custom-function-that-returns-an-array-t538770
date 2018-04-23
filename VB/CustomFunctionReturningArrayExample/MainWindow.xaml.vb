Imports System.Windows

Namespace CustomFunctionReturningArrayExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Ribbon.DXRibbonWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SpreadsheetControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            spreadsheet.CreateNewDocument()
            spreadsheet.ActiveWorksheet.Range("$A$1:$E$2").FillColor = System.Drawing.Color.Honeydew

'            #Region "#TestArrayCustomFunctionAdd"
            Dim customFunction As New TestArrayCustomFunction()
            If Not spreadsheet.Document.Functions.CustomFunctions.Contains(customFunction.Name) Then
                spreadsheet.Document.Functions.CustomFunctions.Add(customFunction)
            End If

            spreadsheet.ActiveWorksheet.Range("$A$4:$E$5").ArrayFormulaInvariant = "TESTARRAY(A1:E2)"
            spreadsheet.ActiveWorksheet.Range("E7").Formula = "SUM(TESTARRAY(A1:E2))"
'            #End Region ' #TestArrayCustomFunctionAdd
        End Sub
    End Class
End Namespace
