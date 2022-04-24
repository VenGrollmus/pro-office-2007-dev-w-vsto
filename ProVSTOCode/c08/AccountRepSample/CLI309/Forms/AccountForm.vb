Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class AccountForm

#Region "Form Region Factory"

  <Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Contact.Account")> _
  <Microsoft.Office.Tools.Outlook.FormRegionName("CLI309.AccountForm")> _
  Partial Public Class AccountFormFactory

    Private Sub InitializeManifest()
      Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AccountForm))
      Me.Manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.ReplaceAll
      Me.Manifest.Title = resources.GetString("Title")
      Me.Manifest.FormRegionName = resources.GetString("FormRegionName")
      Me.Manifest.Description = resources.GetString("Description")
      Me.Manifest.ShowInspectorCompose = True
      Me.Manifest.ShowInspectorRead = True
      Me.Manifest.ShowReadingPane = True

    End Sub

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
    Private Sub AccountFormFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

  End Class

#End Region

  ' Occurs before the form region is displayed.
  ' Use Me.OutlookItem to get a reference to the current Outlook item.
  ' Use Me.OutlookFormRegion to get a reference to the form region.
  Private Sub AccountForm_FormRegionShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing

  End Sub

  ' Occurs when the form region is closed.
  ' Use Me.OutlookItem to get a reference to the current Outlook item.
  ' Use Me.OutlookFormRegion to get a reference to the form region.
  Private Sub AccountForm_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed
    Try
      Dim ci As Outlook.ContactItem = DirectCast(Me.OutlookItem, Outlook.ContactItem)
      SalesPipeData.UpdateAccount(ci.UserProperties("SalesSystemID").Value, ci.CompanyName, ci.FirstName, ci.LastName, ci.Email1Address, ci.BusinessTelephoneNumber, ci.Body)

    Catch ex As Exception

    End Try


    
  End Sub

End Class
