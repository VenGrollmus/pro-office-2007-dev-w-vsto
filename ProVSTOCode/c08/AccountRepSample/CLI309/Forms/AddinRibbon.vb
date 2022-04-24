Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Tools
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class AddinRibbon

  Private Sub AddinRibbon_Load(ByVal sender As System.Object, _
   ByVal e As RibbonUIEventArgs) Handles MyBase.Load
    btnToggleOpps.Checked = True
  End Sub


  Private Sub btnToggleOpps_Click(ByVal sender As System.Object, _
   ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) _
   Handles btnToggleOpps.Click
    Dim inspector As Outlook.Inspector = e.Control.Context
    Dim manager As TaskPaneManager = Globals.ThisAddIn.TaskPaneManagers(inspector)
    Dim tp As CustomTaskPane = manager.TaskPaneControl

    If Not (tp Is Nothing) Then
      tp.Visible = TryCast(sender, RibbonToggleButton).Checked
      If tp.Visible Then
        btnToggleOpps.Label = "Hide Opportunities"
      Else
        btnToggleOpps.Label = "Show Opportunities"
      End If
    End If
  End Sub

  Private Sub btnCreateProject_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnCreateProject.Click
    Dim inspector As Outlook.Inspector = e.Control.Context
    Dim manager As TaskPaneManager = Globals.ThisAddIn.TaskPaneManagers(inspector)
    Dim tp As CustomTaskPane = manager.TaskPaneControl
    If Not (tp Is Nothing) Then
      Dim pane = DirectCast(tp.Control, ItemActionPane)
      Dim id As String = pane.OpportunityID

      'Send opportunity data and create project
      Dim opp As Opportunity = SalesPipeData.GetOpportunity(id)
      Dim ProjectID As Guid = SBATools.CreateProject(opp)

      'If successful, update Opp in Sales DB and close it out
      SalesPipeData.CloseOpportunity(opp.OpportunityID, ProjectID)
      pane.RefreshData()
      MsgBox("The new project was created successfully", MsgBoxStyle.Information, "Project Created")


    End If
  End Sub




End Class
