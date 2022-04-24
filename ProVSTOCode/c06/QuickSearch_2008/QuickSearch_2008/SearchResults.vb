Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class SearchResults
  Private _dt As System.Data.DataTable

  

  Friend Property ResultsData() As System.Data.DataTable
    Get
      Return _dt
    End Get
    Set(ByVal value As System.Data.DataTable)
      _dt = value
      dgResults.DataSource = _dt
    End Set
  End Property


  Private Sub dgResults_CellDoubleClick(ByVal sender As  _
    System.Object, ByVal e As System.Windows.Forms. _
    DataGridViewCellEventArgs) Handles dgResults.CellDoubleClick

    If dgResults.SelectedRows.Count > 0 Then
      Dim dgRow As DataGridViewRow = dgResults.SelectedRows(0)
      Dim objMail As Outlook.MailItem

      objMail = Globals.ThisAddIn.Application.Session. _
        GetItemFromID(dgRow.Cells("EntryID").Value)

      objMail.Display()
    End If


  End Sub
End Class