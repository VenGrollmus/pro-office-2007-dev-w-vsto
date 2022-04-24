Imports Microsoft.Office.Tools.Ribbon


Public Class LibraryRibbon
  Private Sub LibraryRibbon_Load(ByVal sender As System.Object, _
    ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    Me.TemplatesPath.Text = My.Settings.TemplatesFolderPath
    LoadTemplates()
  End Sub


  Private Sub btnChangeTemplatesFolder_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnChangeTemplatesFolder.Click
    Me.TemplatesPath.Text = PickTemplatesFolder()
    My.Settings.TemplatesFolderPath = Me.TemplatesPath.Text
    My.Settings.Save()
    LoadTemplates()
  End Sub
  Private Sub TemplateGallery_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles TemplateGallery.Click
    Dim s As RibbonGallery = sender

    Globals.ThisAddIn.Application.Documents.Add(My.Settings.TemplatesFolderPath & "\" & s.SelectedItem.Tag)

  End Sub
  Private Sub LoadTemplates()
    Dim fld As New System.IO.DirectoryInfo(My.Settings.TemplatesFolderPath)
    For Each f As System.IO.FileInfo In fld.GetFiles("*.do*")
      Dim ddi As New RibbonDropDownItem
      ddi.Label = f.Name
      ddi.Tag = f.Name
      ddi.Image = My.Resources.Generic_Document
      TemplateGallery.Items.Add(ddi)

    Next
  End Sub
  Private Function PickTemplatesFolder() As String
    Dim path As String = ""
    Me.FolderBrowserDialog1.SelectedPath = My.Settings.TemplatesFolderPath
    If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
      path = FolderBrowserDialog1.SelectedPath
    End If

    Return path
  End Function




  
End Class
