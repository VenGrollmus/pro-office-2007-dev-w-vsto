Imports Microsoft.Office.Tools.Ribbon
Imports W = Microsoft.Office.Interop.Word
Imports OL = Microsoft.Office.Interop.Outlook

Public Class FaxRibbon

  Private Sub FaxRibbon_Load(ByVal sender As System.Object, _
    ByVal e As RibbonUIEventArgs) Handles MyBase.Load


    Dim folder As OL.Folder = GetTemplatesFolder()
    txtLocation.Text = folder.FolderPath
    FillTemplatesComboBox(folder)
  End Sub


#Region "1. CreateCoverCode"

  Private Function FillTemplatesComboBox( _
      ByVal folder As OL.Folder) As Boolean

    Try
      For Each itm As OL.PostItem In folder.Items
        Dim dditm As New RibbonDropDownItem
        dditm.Label = itm.Subject
        cboTemplate.Items.Add(dditm)
      Next
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try

  End Function

  Private Function GetTemplatesFolder() As OL.Folder

    Dim fldStorage As OL.MAPIFolder
    Dim fld As OL.Folder = Nothing
    Dim ns As OL.NameSpace = Globals.ThisAddIn. _
      Application.GetNamespace("MAPI")
    fldStorage = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)

    'Create and store the item.
    Dim si As OL.StorageItem
    Dim up As OL.UserProperty
    si = fldStorage.GetStorage("FaxCoverSheetAddin.Settings", _
      Outlook.OlStorageIdentifierType.olIdentifyBySubject)

    'The only way to know if the item is new is to check its size.
    If si.Size = 0 Then
      'No setting exists.
      fld = Nothing
      Return fld
    Else
      up = si.UserProperties("TemplatesFolder")
      'Now Retrieve the folder use the Path
      Dim arry As Array
      Dim i As Integer
      Dim path As String = Right(up.Value, Len(up.Value) - 2)
      arry = path.Split("\")
      Dim fldRoot As OL.Folder
      fldRoot = Globals.ThisAddIn.Application.Session.Folders.Item(arry(0))
      Dim fldrsSub As OL.Folders
      fldrsSub = fldRoot.Folders

      For i = 1 To arry.Length - 1
        fld = fldrsSub.Item(arry(i))

      Next
      Return fld


    End If
  End Function

  Private Sub btnCreate_Click(ByVal sender As System.Object, _
     ByVal e As Microsoft.Office.Tools.Ribbon. _
     RibbonControlEventArgs) Handles btnCreate.Click

    Dim w As New W.Application
    Dim doc As W.Document
    Dim fldTemplates As OL.Folder = GetTemplatesFolder()
    Dim pi As OL.PostItem = fldTemplates.Items(cboTemplate.Text)
    Dim at As OL.Attachment = pi.Attachments(1)
    Dim strPath As String = My.Computer.FileSystem. _
      SpecialDirectories.MyDocuments & "\faxcoversheet.docx"

    at.SaveAsFile(strPath)
    w.Documents.Open(strPath)
    doc = w.Application.ActiveDocument

    Dim ciRec As OL.ContactItem = _
      Globals.ThisAddIn.Application.ActiveInspector.CurrentItem

    Dim ciSender As OL.ContactItem = _
      GetUserContact(Globals.ThisAddIn.Application. _
                     Session.CurrentUser.Name)


    For Each ctl As W.ContentControl In doc.ContentControls
      Select Case ctl.Title
        Case "RecipientName"
          ctl.Range.Text = ciRec.FullName
        Case "RecipientPhone"
          ctl.Range.Text = ciRec.BusinessTelephoneNumber
        Case "RecipientCompanyName"
          ctl.Range.Text = ciRec.CompanyName
        Case "RecipientFax"
          ctl.Range.Text = ciRec.BusinessFaxNumber
        Case "SenderName"
          ctl.Range.Text = ciSender.FullName
        Case "SenderPhone"
          ctl.Range.Text = ciSender.BusinessTelephoneNumber
        Case "SenderCompanyName"
          ctl.Range.Text = ciSender.CompanyName
        Case "SenderFax"
          ctl.Range.Text = ciSender.BusinessFaxNumber
        Case "FaxDate"
          ctl.Range.Text = Format(Today(), "Short Date")
        Case "NumberOfPages"
          ctl.Range.Text = Me.txtNumberOfPages.Text.ToString
        Case "Urgent"
          ctl.Range.Text = chkUrgent.Enabled.ToString

        Case Else

      End Select
    Next

    'Now that we are done, show the user the completed
    'file within Word.
    w.Visible = True

  End Sub

  Private Function GetUserContact(ByVal name As String) As  _
    Outlook.ContactItem

    Dim folder As Outlook.Folder
    Dim contact As Outlook.ContactItem
    folder = Globals.ThisAddIn.Application.Session. _
      GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts)

    contact = folder.Items.Find("[FullName] = '" & name & "'")

    Return contact

  End Function

#End Region

#Region "2. Settings Code"
  Private Function SelectTemplatesFolder() As String
    Dim strPath As String = ""
    Dim fldSelect As OL.Folder
    'Use the NameSpace object in order to use the SelectFolder dialog box
    Dim ns As OL.NameSpace = Globals.ThisAddIn.Application.GetNamespace("MAPI")
    fldSelect = ns.PickFolder


    'Now store the name of the selected foler as a hidden StorageItem in the Default Notes folder.
    Dim fldStorage As OL.Folder
    fldStorage = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)


    'Create and store the item.
    Dim si As OL.StorageItem
    Dim up As OL.UserProperty
    si = fldStorage.GetStorage("FaxCoverSheetAddin.Settings", Outlook.OlStorageIdentifierType.olIdentifyBySubject)
    'The only way to know if the item is new is to check its size.
    If si.Size = 0 Then
      up = si.UserProperties.Add("TemplatesFolder", Outlook.OlUserPropertyType.olText)
    Else
      up = si.UserProperties("TemplatesFolder")
    End If
    up.Value = fldSelect.FolderPath.ToString
    si.Subject = "FaxCoverSheetAddin.Settings"
    si.Save()
    strPath = up.Value
    Return strPath

  End Function
 
#End Region


  Private Sub btnChangeSettings_Click_1(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnChangeSettings.Click
    txtLocation.Text = SelectTemplatesFolder()
  End Sub
End Class
