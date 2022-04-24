Partial Class LibraryRibbon
  Inherits Microsoft.Office.Tools.Ribbon.OfficeRibbon

  <System.Diagnostics.DebuggerNonUserCode()> _
 Public Sub New(ByVal container As System.ComponentModel.IContainer)
    MyClass.New()

    'Required for Windows.Forms Class Composition Designer support
    If (container IsNot Nothing) Then
      container.Add(Me)
    End If

  End Sub

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Component Designer.
    InitializeComponent()

  End Sub

  'Component overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Component Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Component Designer
  'It can be modified using the Component Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Tab1 = New Microsoft.Office.Tools.Ribbon.RibbonTab
    Me.TempateGroup = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.TemplateGallery = New Microsoft.Office.Tools.Ribbon.RibbonGallery
    Me.SettingsGroup = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.Box1 = New Microsoft.Office.Tools.Ribbon.RibbonBox
    Me.btnChangeTemplatesFolder = New Microsoft.Office.Tools.Ribbon.RibbonButton
    Me.Label1 = New Microsoft.Office.Tools.Ribbon.RibbonLabel
    Me.TemplatesPath = New Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
    Me.Tab1.SuspendLayout()
    Me.TempateGroup.SuspendLayout()
    Me.SettingsGroup.SuspendLayout()
    Me.Box1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Tab1
    '
    Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
    Me.Tab1.Groups.Add(Me.TempateGroup)
    Me.Tab1.Groups.Add(Me.SettingsGroup)
    Me.Tab1.Label = "Document Templates"
    Me.Tab1.Name = "Tab1"
    '
    'TempateGroup
    '
    Me.TempateGroup.Items.Add(Me.TemplateGallery)
    Me.TempateGroup.Label = "Select a Template"
    Me.TempateGroup.Name = "TempateGroup"
    '
    'TemplateGallery
    '
    Me.TemplateGallery.ColumnCount = 1
    Me.TemplateGallery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
    Me.TemplateGallery.Image = Global.TemplateLibrary.My.Resources.Resources.Stuffed_Folder
    Me.TemplateGallery.Label = "Templates"
    Me.TemplateGallery.Name = "TemplateGallery"
    Me.TemplateGallery.ShowImage = True
    '
    'SettingsGroup
    '
    Me.SettingsGroup.Items.Add(Me.Box1)
    Me.SettingsGroup.Items.Add(Me.Label1)
    Me.SettingsGroup.Items.Add(Me.TemplatesPath)
    Me.SettingsGroup.Label = "Template Library Settings"
    Me.SettingsGroup.Name = "SettingsGroup"
    '
    'Box1
    '
    Me.Box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
    Me.Box1.Items.Add(Me.btnChangeTemplatesFolder)
    Me.Box1.Name = "Box1"
    '
    'btnChangeTemplatesFolder
    '
    Me.btnChangeTemplatesFolder.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
    Me.btnChangeTemplatesFolder.Image = Global.TemplateLibrary.My.Resources.Resources.Gear
    Me.btnChangeTemplatesFolder.Label = "Change Templates Location"
    Me.btnChangeTemplatesFolder.Name = "btnChangeTemplatesFolder"
    Me.btnChangeTemplatesFolder.ShowImage = True
    '
    'Label1
    '
    Me.Label1.Label = "   Templates Location"
    Me.Label1.Name = "Label1"
    '
    'TemplatesPath
    '
    Me.TemplatesPath.Enabled = False
    Me.TemplatesPath.Label = " "
    Me.TemplatesPath.Name = "TemplatesPath"
    Me.TemplatesPath.SizeString = "11111111111111111111111111111111111111111111111111111111111111"
    Me.TemplatesPath.Text = "                                                      "
    '
    'FolderBrowserDialog1
    '
    Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
    '
    'LibraryRibbon
    '
    Me.Name = "LibraryRibbon"
    Me.RibbonType = "Microsoft.Word.Document"
    Me.Tabs.Add(Me.Tab1)
    Me.Tab1.ResumeLayout(False)
    Me.Tab1.PerformLayout()
    Me.TempateGroup.ResumeLayout(False)
    Me.TempateGroup.PerformLayout()
    Me.SettingsGroup.ResumeLayout(False)
    Me.SettingsGroup.PerformLayout()
    Me.Box1.ResumeLayout(False)
    Me.Box1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
  Friend WithEvents TempateGroup As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents TemplateGallery As Microsoft.Office.Tools.Ribbon.RibbonGallery
  Friend WithEvents SettingsGroup As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents btnChangeTemplatesFolder As Microsoft.Office.Tools.Ribbon.RibbonButton
  Friend WithEvents TemplatesPath As Microsoft.Office.Tools.Ribbon.RibbonEditBox
  Friend WithEvents Box1 As Microsoft.Office.Tools.Ribbon.RibbonBox
  Friend WithEvents Label1 As Microsoft.Office.Tools.Ribbon.RibbonLabel
  Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class

Partial Class ThisRibbonCollection
  Inherits Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection

  <System.Diagnostics.DebuggerNonUserCode()> _
  Friend ReadOnly Property Ribbon1() As LibraryRibbon
    Get
      Return Me.GetRibbon(Of LibraryRibbon)()
    End Get
  End Property
End Class
