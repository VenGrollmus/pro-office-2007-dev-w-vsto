Public Class ReadingPane2

#Region "Form Region Factory"

    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Note.MODVSTO")> _
    <Microsoft.Office.Tools.Outlook.FormRegionName("CustomReadingPane.ReadingPane2")> _
    Partial Public Class ReadingPane2Factory

    Private Sub InitializeManifest()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReadingPane2))
            Me.Manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Replacement
            Me.Manifest.Title = resources.GetString("Title")
            Me.Manifest.FormRegionName = resources.GetString("FormRegionName")
            Me.Manifest.Description = resources.GetString("Description")
            Me.Manifest.ShowInspectorCompose = False
            Me.Manifest.ShowInspectorRead = False
            Me.Manifest.ShowReadingPane = True

    End Sub

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub ReadingPane2Factory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

    End Class

#End Region

    ' Occurs before the form region is displayed.
    ' Use this.OutlookItem to get a reference to the current Outlook item.
    ' Use this.OutlookFormRegion to get a reference to the form region.
    Private Sub ReadingPane2_FormRegionShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing

    End Sub

    ' Occurs when the form region is closed.
    ' Use this.OutlookItem to get a reference to the current Outlook item.
    ' Use this.OutlookFormRegion to get a reference to the form region.
    Private Sub ReadingPane2_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

End Class
