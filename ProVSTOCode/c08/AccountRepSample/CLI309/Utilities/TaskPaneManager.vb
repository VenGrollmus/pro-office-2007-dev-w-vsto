Imports System.Collections.Generic
Imports Tools = Microsoft.Office.Tools
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Core


Public Class TaskPaneManager
  Private WithEvents _inspector As Outlook.Inspector
  Private WithEvents _taskpane As Tools.CustomTaskPane

  Public Sub New(ByVal Inspector As Outlook.Inspector)
    Dim pane As New ItemActionPane
    pane.Contact = DirectCast(Inspector.CurrentItem, Outlook.ContactItem)
    _inspector = Inspector
    _taskpane = Globals.ThisAddIn.CustomTaskPanes.Add(pane, "Related Item Information", _inspector)
    _taskpane.Width = 345
    _taskpane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight
    _taskpane.Visible = True


  End Sub


  Private Sub _inspector_Close() Handles _inspector.Close
    Try
      If Not (_taskpane Is Nothing) Then
        Globals.ThisAddIn.CustomTaskPanes.Remove(_taskpane)
      End If

      _taskpane = Nothing
      Globals.ThisAddIn.TaskPaneManagers.Remove(DirectCast(_inspector, Outlook.Inspector))
      RemoveHandler _inspector.Close, AddressOf _inspector_Close
      '' _inspector = Nothing
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub


  Public ReadOnly Property TaskPaneControl() As Tools.CustomTaskPane
    Get
      Return _taskpane
    End Get
  End Property

End Class

