Imports Microsoft.Office.Tools.Ribbon

Public Class SearchRibbon

    Private Sub SearchRibbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnSearch.Click

    GetTableSearch(Me.txtSearchString.ToString())
  End Sub


  Private Sub GetExplorerSearch(ByVal SearchString As String)
    Dim exp As Outlook.Explorer
    Dim objFindValue As String
    Dim folder As Outlook.Folder
    folder = Globals.ThisAddIn.Application.ActiveExplorer.CurrentFolder

    exp = Globals.ThisAddIn.Application.Explorers.Add(folder, Outlook.OlFolderDisplayMode.olFolderDisplayNoNavigation)
    'exp = Globals.ThisAddIn.Application.ActiveExplorer
    objFindValue = "contents:'" & txtSearchString.Text & "'"

    exp.Search(objFindValue, Outlook.OlSearchScope.olSearchScopeCurrentFolder)
    'exp.Search(objFindValue, Outlook.OlSearchScope.olSearchScopeAllFolders)

    exp.Display()
    exp.Activate()
  End Sub
  Private Sub GetTableSearch(ByVal SearchString As String)
    Dim objTable As Outlook.Table
    Dim objColumns As Outlook.Columns
    Dim objFolder As Outlook.Folder
    Dim objFindValue As String


    objFolder = Globals.ThisAddIn.Application.ActiveExplorer.CurrentFolder

    objFindValue = "@SQL=" & Chr(34) _
      & "urn:schemas:httpmail:subject" _
      & Chr(34) & " ci_startswith '" & _
        txtSearchString.Text & "'"



    objTable = objFolder.GetTable(objFindValue, Outlook. _
       OlTableContents.olUserItems)

    objColumns = objTable.Columns
    objColumns.Add("From")
    objColumns.Add("Received")
    objColumns.Add("Importance")

    Dim objForm As New SearchResults()
    objForm.ResultsData = CreatedataTable(objTable)
    objForm.Show()
    objForm.Activate()
  End Sub


  Private Function CreatedataTable(ByVal table As Outlook.Table) _
  As System.Data.DataTable

    Dim objDataTable As New Data.DataTable
    Dim objRow As Outlook.Row
    objDataTable.Columns.Add(MakeColumn("Importance"))
    objDataTable.Columns.Add(MakeColumn("From"))
    objDataTable.Columns.Add(MakeColumn("Subject"))
    objDataTable.Columns.Add(MakeColumn("Received"))
    objDataTable.Columns.Add(MakeColumn("MessageClass"))
    objDataTable.Columns.Add(MakeColumn("EntryID"))
    Do Until table.EndOfTable
      objRow = table.GetNextRow
      Dim objDataRow As Data.DataRow = objDataTable.Rows.Add()
      objDataRow.Item("Importance") = objRow("Importance")
      objDataRow.Item("From") = objRow("From")
      objDataRow.Item("Subject") = objRow("Subject")
      objDataRow.Item("Received") = objRow("Received")
      objDataRow.Item("MessageClass") = objRow("MessageClass")
      objDataRow.Item("EntryID") = objRow("EntryID")
    Loop


    Return objDataTable


  End Function


  Private Function MakeColumn(ByVal name As String) As Data.DataColumn
    Dim objColumn As New Data.DataColumn
    With objColumn
      .Caption = name
      .ColumnName = name
      .AllowDBNull = True
    End With
    Return objColumn
  End Function

End Class
