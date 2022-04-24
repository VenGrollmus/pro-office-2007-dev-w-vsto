Imports Microsoft.Office.Interop.Word

Public Class DocSnippets
  Private Sub DocSnippets_Load(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles MyBase.Load

    Dim controls As ContentControls
    controls = Globals.ThisDocument.ContentControls

    For Each ctl As ContentControl In controls

      Me.cboContentControlList.Items.Add(ctl.Tag)
    Next

    Me.SnippetsTableAdapter1.Fill(Me.DocSnippetsDataSet1.Snippets)

  End Sub

  
  Private Sub SnippetsDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnippetsDataGridView.SelectionChanged
    Me.PreviewBox.Text = SnippetsDataGridView.CurrentRow.Cells(2).Value.ToString()

  End Sub

  Private Sub SnippetsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.Validate()
    Me.SnippetsBindingSource.EndEdit()


  End Sub

  Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.SnippetsBindingSource.AddNew()

  End Sub

  Private Sub SnippetsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnippetsBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.SnippetsBindingSource.EndEdit()
    Me.TableAdapterManager1.UpdateAll(Me.DocSnippetsDataSet1)

  End Sub

  

  Private Sub InsertSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertSelection.Click
    'Get the current selection
    Dim r As Range = Globals.ThisDocument.Application.Selection.Range
    Me.SnippetsBindingSource.AddNew()
    Me.SnippetsDataGridView.CurrentRow.Cells(2).Value = r.Text

  End Sub

  Private Sub CreateBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBlock.Click
    Dim r As Range = Globals.ThisDocument.Application.Selection.Range

    Globals.ThisDocument.Application.Templates.LoadBuildingBlocks()
    Dim BBs As Template = Globals.ThisDocument.Application.Templates(1)
    BBs.BuildingBlockEntries.Add("New BB", WdBuildingBlockTypes.wdTypeCustomAutoText, "Report Content", r)
    BBs.Save()
  End Sub

  Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
    For Each ctl As ContentControl In Globals.ThisDocument.ContentControls
      If ctl.Tag = cboContentControlList.SelectedItem Then
        ctl.Range.Text = SnippetsDataGridView.CurrentRow.Cells(2).Value.ToString()
      End If

    Next




  End Sub

  Private Sub cboContentControlList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContentControlList.SelectedIndexChanged

  End Sub
End Class
