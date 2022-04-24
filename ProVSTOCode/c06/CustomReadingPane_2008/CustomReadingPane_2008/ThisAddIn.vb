Public Class ThisAddIn

    Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

    End Sub

    Private Sub ThisAddIn_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

  End Sub

  Private Sub Application_NewMailEx(ByVal EntryIDCollection _
    As String) Handles Application.NewMailEx

    Dim mail As Outlook.MailItem
    mail = Globals.ThisAddIn.Application.Session. _
    GetItemFromID(EntryIDCollection)
    ChangeMessageClass(mail)
  End Sub

  Private Sub ChangeMessageClass(ByVal mail As Outlook.MailItem)
    Dim newClass As String = "IPM.Note.MODVSTO"

    mail.MessageClass = newClass
    mail.Save()

  End Sub

End Class
