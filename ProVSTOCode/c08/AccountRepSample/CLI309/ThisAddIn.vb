Imports Tools = Microsoft.Office.Tools
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Core = Microsoft.Office.Core


Public Class ThisAddIn

#Region "Class Variables"

  Private WithEvents _inspectors As Outlook.Inspectors
  Private WithEvents _inspector As Outlook.Inspector
  Private WithEvents _explorer As Outlook.Explorer
  Private _commandBar As Core.CommandBar
  Private WithEvents _cbbSyncAccounts As Core.CommandBarButton
  Private WithEvents _cbbNewAccount As Core.CommandBarButton
  Public TaskPaneManagers As New Dictionary(Of Outlook.Inspector, TaskPaneManager)
#End Region

  Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
    _inspectors = Me.Application.Inspectors
    _explorer = Me.Application.ActiveExplorer

    For Each inspector As Outlook.Inspector In _inspectors
      _inspectors_NewInspector(inspector)
    Next

    _commandBar = Me.Application.ActiveExplorer.CommandBars.Add("AccountBar", , , True)
    _commandBar.Position = Core.MsoBarPosition.msoBarTop
    _commandBar.Visible = True
    _cbbSyncAccounts = _commandBar.Controls.Add(Core.MsoControlType.msoControlButton, , , , True)
    With _cbbSyncAccounts
      .Caption = "Sync Sales Account Data"
      .Style = Core.MsoButtonStyle.msoButtonIconAndCaption
      .FaceId = 487
    End With

    _cbbNewAccount = _commandBar.Controls.Add(Core.MsoControlType.msoControlButton, , , , True)
    _cbbNewAccount.Caption = "Create New Acount"
  End Sub


  Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    RemoveHandler _inspectors.NewInspector, AddressOf _inspectors_NewInspector

    Try
      _inspectors = Nothing

    Catch ex As Exception

    End Try

    Try
      TaskPaneManagers = Nothing
    Catch ex As Exception

    End Try
  End Sub


  Private Sub _inspectors_NewInspector(ByVal Inspector As Outlook.Inspector) Handles _inspectors.NewInspector
    Try
      'Only show task pane for ContactItems
      If TypeOf Inspector.CurrentItem Is Outlook.ContactItem Then
        TaskPaneManagers.Add(Inspector, New TaskPaneManager(Inspector))

      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try


  End Sub

  Private Sub _cbbSyncAccounts_Click(ByVal Ctrl As Core.CommandBarButton, ByRef CancelDefault As Boolean) Handles _cbbSyncAccounts.Click
    SalesPipeData.ImportSalesAccounts()
  End Sub

  Private Sub _cbbNewAccount_Click(ByVal Ctrl As  _
   Microsoft.Office.Core.CommandBarButton, _
   ByRef CancelDefault As Boolean) Handles _cbbNewAccount.Click
    Dim ci As Outlook.ContactItem = Globals.ThisAddIn.Application. _
      ActiveExplorer.CurrentFolder.Items.Add("IPM.Contact.Account")

    ci.MessageClass = "IPM.Contact.Account"
    ci.FirstName = "Ty"
    ci.Body = "Notes"

    ci.Close(Outlook.OlInspectorClose.olSave)
  End Sub
End Class
