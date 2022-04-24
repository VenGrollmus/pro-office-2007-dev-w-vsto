Public Class ThisDocument

  Private Sub ThisDocument_Startup(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Startup

    Globals.ThisDocument.CustomMessage.Text = "Hello World!"
  End Sub

  Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

  End Sub

End Class
