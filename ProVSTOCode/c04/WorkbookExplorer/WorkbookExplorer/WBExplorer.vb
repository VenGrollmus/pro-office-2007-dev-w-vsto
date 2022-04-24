

Public Class WBExplorer
  Private ndWorkbooks As Windows.Forms.TreeNode
  Public SelectedNode As Windows.Forms.TreeNode
  Public KeepSelectedNode As Boolean


  Private Sub WBExplorer_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load

    ndWorkbooks = tvWorkbooks.Nodes. _
      Add("WEX.Workbooks", "Workbooks", 0, 0)

  End Sub

  Friend Sub AddWorksheet(ByVal workbook As Excel.Workbook, _
                          ByVal sheet As Excel.Worksheet)

    Dim nodeWB As Windows.Forms.TreeNode = _
      ndWorkbooks.Nodes(workbook.Name)
    Dim nodeS As Windows.Forms.TreeNode = nodeWB.Nodes("Sheets")

    Dim SheetNode As Windows.Forms.TreeNode = _
        nodeS.Nodes.Add(workbook.Name & "!" & _
                        sheet.Name, sheet.Name, 1, 1)
    SheetNode.Tag = "Sheets"
  End Sub


  Friend Sub DeleteWorkbook(ByVal workbook As Excel.Workbook)
    Dim node As Windows.Forms.TreeNode = _
      ndWorkbooks.Nodes(workbook.Name)

    ndWorkbooks.Nodes.Remove(node)
  End Sub



  Friend Sub AddWorkbook(ByVal workbook As Excel.Workbook)
    Dim nodeWb As Windows.Forms.TreeNode

    nodeWb = ndWorkbooks.Nodes.Add(workbook.Name, _
                                   workbook.Name, 0, 0)
    Dim nodeS As Windows.Forms.TreeNode = _
      nodeWb.Nodes.Add("Sheets", "Sheets", 1, 1)
    Dim nodeR As Windows.Forms.TreeNode = _
      nodeWb.Nodes.Add("Ranges", "Named Ranges", 2, 2)
    Dim nodeLst As Windows.Forms.TreeNode = _
      nodeWb.Nodes.Add("TableObjects", "Tables", 3, 3)

    ''Loop through all sheets in the wb
    ''add a node for each sheet
    ''add nodes for each list in each sheet.
    For Each ws As Excel.Worksheet In workbook.Sheets
      Dim SheetNode As Windows.Forms.TreeNode = _
        nodeS.Nodes.Add(workbook.Name & "!" & ws.Name, ws.Name, 1, 1)
      SheetNode.Tag = "Sheets"

      AddListObjectNodes(nodeLst, ws, workbook)


    Next

    'Add nodes for each Named Range in each Sheet.
    For Each n As Excel.Name In workbook.Names
      Dim RangeNode2 As Windows.Forms.TreeNode = _
        nodeR.Nodes.Add(workbook.Name & "!" & n.Name, n.Name, 3, 3)
      RangeNode2.Tag = "Ranges"
    Next

  End Sub

  Private Sub AddWorksheetNodes(ByVal node As  _
    Windows.Forms.TreeNode, ByVal sheet As Excel.Worksheet)
    For Each n As Excel.Name In sheet.Names

    Next
  End Sub

  Private Sub AddListObjectNodes(ByVal node As  _
    Windows.Forms.TreeNode, ByVal sheet As Excel.Worksheet, _
    ByVal workbook As Excel.Workbook)

    For Each l As Excel.ListObject In sheet.ListObjects

      Dim newNode As Windows.Forms.TreeNode = _
        node.Nodes.Add(workbook.Name & "!" & l.Name, l.Name, 3, 3)
      newNode.Tag = "Tables"
    Next
  End Sub

  Private Sub tvWorkbooks_ControlAdded(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.ControlEventArgs)


    ndWorkbooks.ExpandAll()
  End Sub




  Private Sub NavigateToSelection(ByVal node As  _
                                  Windows.Forms.TreeNode)

    Dim str() As String = node.Name.Split("!")
    Dim wb As Excel.Workbook = _
    Globals.ThisAddIn.Application.Workbooks(Str(0))



    If Not node.Tag Is Nothing Then
      Select Case node.Tag.ToString
        Case "Sheets"
          Dim s As Excel.Worksheet = wb.Sheets(str(1))
          s.Activate()
        Case "Ranges"

          Globals.ThisAddIn.Application.Goto(str(1))
        Case "Tables"

          wb.Activate()
          Globals.ThisAddIn.Application.Goto(str(1))
        Case Else
      End Select
    End If
  End Sub

  Private Sub tvWorkbooks_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    'ndWorkbooks.ExpandAll()
    'If Not KeepSelectedNode Then
    '  SelectedNode = e.Node
    '  SelectedNode.ExpandAll()
    'End If
  End Sub


  Private Sub btnRefresh_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)

    Globals.ThisAddIn.RefreshAll()
  End Sub

  Private Sub tvWorkbooks_NodeMouseDoubleClick_1(ByVal sender _
   As System.Object, ByVal e As System.Windows.Forms. _
   TreeNodeMouseClickEventArgs) Handles _
   tvWorkbooks.NodeMouseDoubleClick

    Dim str() As String = e.Node.Name.Split("!")
    Dim wb As Excel.Workbook = _
    Globals.ThisAddIn.Application.Workbooks(str(0))



    If Not e.Node.Tag Is Nothing Then
      Select Case e.Node.Tag.ToString
        Case "Sheets"
          Dim s As Excel.Worksheet = wb.Sheets(str(1))
          s.Activate()
        Case "Ranges"

          Globals.ThisAddIn.Application.Goto(str(1))
        Case "Tables"

          wb.Activate()
          Globals.ThisAddIn.Application.Goto(str(1))
        Case Else
      End Select
    End If
  End Sub
End Class
