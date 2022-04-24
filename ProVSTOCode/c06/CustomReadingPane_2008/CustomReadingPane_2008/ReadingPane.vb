Public Class ReadingPane

#Region "Form Region Factory"

  <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Note.Tyrant")> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("CustomReadingPane.ReadingPane")> _
    Partial Public Class ReadingPaneFactory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
    Private Sub ReadingPaneFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

  End Class

#End Region

    'Occurs before the form region is displayed. 
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
  Private Sub ReadingPane_FormRegionShowing(ByVal sender As _
    Object, ByVal e As System.EventArgs) _
    Handles MyBase.FormRegionShowing

    If TypeOf (Me.OutlookItem) Is Outlook.MailItem Then
      Dim mail As Outlook.MailItem = Me.OutlookItem
      Me.txtBody.Text = mail.Body.ToString

    End If

  End Sub

    'Occurs when the form region is closed.   
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub ReadingPane_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

  Private Sub btnFile_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnFile.Click

    Dim folder As Outlook.Folder
    Dim mi As Outlook.MailItem
    mi = DirectCast(Globals.ThisAddIn.Application. _
      ActiveExplorer.Selection.Item(1), Outlook.MailItem)

    folder = Globals.ThisAddIn.Application.Session.PickFolder()

    mi.Move(folder)
  End Sub
End Class
