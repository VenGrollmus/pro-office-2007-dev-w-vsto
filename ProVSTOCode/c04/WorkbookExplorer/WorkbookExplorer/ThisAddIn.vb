Public Class ThisAddIn

  Private _uc As WBExplorer
  'Private WithEvents _wb As Excel.Workbook
  'Private WithEvents _ws As Excel.Worksheet


  Private Sub ThisAddIn_Startup(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Startup
    Dim tp As Microsoft.Office.Tools.CustomTaskPane

    _uc = New WBExplorer
    tp = Me.CustomTaskPanes.Add(_uc, "Workbook Explorer")
    tp.Visible = True

  End Sub

  Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

  End Sub

  Friend Sub RefreshAll()
    _uc.KeepSelectedNode = True
    For Each wb As Excel.Workbook In _
      Globals.ThisAddIn.Application.Workbooks

      _uc.DeleteWorkbook(wb)
      _uc.AddWorkbook(wb)
    Next
    _uc.tvWorkbooks.Nodes(0).ExpandAll()
    _uc.KeepSelectedNode = False
  End Sub


  Private Sub Application_NewWorkbook(ByVal Wb As Microsoft.Office.Interop.Excel.Workbook) Handles Application.NewWorkbook
    RefreshAll()

  End Sub


  Private Sub Application_SheetCalculate(ByVal Sh As Object) Handles Application.SheetCalculate
    RefreshAll()


  End Sub

  Private Sub Application_SheetChange(ByVal Sh As Object, ByVal Target As Microsoft.Office.Interop.Excel.Range) Handles Application.SheetChange
    'Dim workbook As Excel.Worksheet = Sh.Parent
    '_uc.DeleteWorkbook(workbook)
    '_uc.AddWorkbook(workbook)
    '' RefreshAll()
  End Sub

  Private Sub Application_SheetDeactivate(ByVal Sh As Object) Handles Application.SheetDeactivate
    RefreshAll()
  End Sub

  Private Sub Application_WorkbookActivate(ByVal Wb As Microsoft.Office.Interop.Excel.Workbook) Handles Application.WorkbookActivate
    RefreshAll()

  End Sub

  Private Sub Application_WorkbookBeforeClose(ByVal Wb As Microsoft.Office.Interop.Excel.Workbook, ByRef Cancel As Boolean) Handles Application.WorkbookBeforeClose
    ''_uc.DeleteWorkbook(Wb)
    RefreshAll()
  End Sub

  Private Sub Application_WorkbookNewSheet(ByVal _
    Wb As Microsoft.Office.Interop.Excel.Workbook, _
    ByVal Sh As Object) Handles Application.WorkbookNewSheet

    _uc.AddWorksheet(Wb, Sh)
  End Sub

  Private Sub Application_WorkbookOpen(ByVal Wb As  _
    Microsoft.Office.Interop.Excel.Workbook) _
    Handles Application.WorkbookOpen

    _uc.AddWorkbook(Wb)

  End Sub

End Class
