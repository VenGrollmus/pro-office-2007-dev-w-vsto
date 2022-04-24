
Partial Class FaxRibbon
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
    Me.FaxTab = New Microsoft.Office.Tools.Ribbon.RibbonTab
    Me.Step1 = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.Box1 = New Microsoft.Office.Tools.Ribbon.RibbonBox
    Me.cboTemplate = New Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Me.txtNumberOfPages = New Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Me.chkUrgent = New Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Me.Step2 = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.btnCreate = New Microsoft.Office.Tools.Ribbon.RibbonButton
    Me.AddinSettings = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.Box2 = New Microsoft.Office.Tools.Ribbon.RibbonBox
    Me.btnChangeSettings = New Microsoft.Office.Tools.Ribbon.RibbonButton
    Me.Separator1 = New Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Me.txtLocation = New Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Me.FaxTab.SuspendLayout()
    Me.Step1.SuspendLayout()
    Me.Box1.SuspendLayout()
    Me.Step2.SuspendLayout()
    Me.AddinSettings.SuspendLayout()
    Me.Box2.SuspendLayout()
    Me.SuspendLayout()
    '
    'FaxTab
    '
    Me.FaxTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
    Me.FaxTab.Groups.Add(Me.Step1)
    Me.FaxTab.Groups.Add(Me.Step2)
    Me.FaxTab.Groups.Add(Me.AddinSettings)
    Me.FaxTab.Label = "Fax Addin"
    Me.FaxTab.Name = "FaxTab"
    '
    'Step1
    '
    Me.Step1.Items.Add(Me.Box1)
    Me.Step1.Label = "Step 1"
    Me.Step1.Name = "Step1"
    '
    'Box1
    '
    Me.Box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
    Me.Box1.Items.Add(Me.cboTemplate)
    Me.Box1.Items.Add(Me.txtNumberOfPages)
    Me.Box1.Items.Add(Me.chkUrgent)
    Me.Box1.Name = "Box1"
    '
    'cboTemplate
    '
    Me.cboTemplate.Label = "Select Template"
    Me.cboTemplate.Name = "cboTemplate"
    Me.cboTemplate.Text = Nothing
    '
    'txtNumberOfPages
    '
    Me.txtNumberOfPages.Label = "No. of Pages"
    Me.txtNumberOfPages.Name = "txtNumberOfPages"
    Me.txtNumberOfPages.SizeString = "0000000000"
    Me.txtNumberOfPages.Text = Nothing
    '
    'chkUrgent
    '
    Me.chkUrgent.Label = "Urgent"
    Me.chkUrgent.Name = "chkUrgent"
    '
    'Step2
    '
    Me.Step2.Items.Add(Me.btnCreate)
    Me.Step2.Label = "Step 2"
    Me.Step2.Name = "Step2"
    '
    'btnCreate
    '
    Me.btnCreate.Image = Global.CreateFaxCoverSheet.My.Resources.Resources.fax
    Me.btnCreate.Label = "Create Cover Sheet"
    Me.btnCreate.Name = "btnCreate"
    Me.btnCreate.ShowImage = True
    '
    'AddinSettings
    '
    Me.AddinSettings.Items.Add(Me.Box2)
    Me.AddinSettings.Items.Add(Me.Separator1)
    Me.AddinSettings.Items.Add(Me.txtLocation)
    Me.AddinSettings.Label = "Fax Coversheet Settings"
    Me.AddinSettings.Name = "AddinSettings"
    '
    'Box2
    '
    Me.Box2.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
    Me.Box2.Items.Add(Me.btnChangeSettings)
    Me.Box2.Name = "Box2"
    '
    'btnChangeSettings
    '
    Me.btnChangeSettings.Image = Global.CreateFaxCoverSheet.My.Resources.Resources.search4files
    Me.btnChangeSettings.Label = "Change Location"
    Me.btnChangeSettings.Name = "btnChangeSettings"
    Me.btnChangeSettings.ShowImage = True
    '
    'Separator1
    '
    Me.Separator1.Name = "Separator1"
    '
    'txtLocation
    '
    Me.txtLocation.Label = "Templates Location"
    Me.txtLocation.Name = "txtLocation"
    Me.txtLocation.ShowLabel = False
    Me.txtLocation.SizeString = "0000000000000000000000000"
    Me.txtLocation.Text = Nothing
    '
    'FaxRibbon
    '
    Me.Name = "FaxRibbon"
    Me.RibbonType = "Microsoft.Outlook.Contact"
    Me.Tabs.Add(Me.FaxTab)
    Me.FaxTab.ResumeLayout(False)
    Me.FaxTab.PerformLayout()
    Me.Step1.ResumeLayout(False)
    Me.Step1.PerformLayout()
    Me.Box1.ResumeLayout(False)
    Me.Box1.PerformLayout()
    Me.Step2.ResumeLayout(False)
    Me.Step2.PerformLayout()
    Me.AddinSettings.ResumeLayout(False)
    Me.AddinSettings.PerformLayout()
    Me.Box2.ResumeLayout(False)
    Me.Box2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents FaxTab As Microsoft.Office.Tools.Ribbon.RibbonTab
  Friend WithEvents Step2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents btnCreate As Microsoft.Office.Tools.Ribbon.RibbonButton
  Friend WithEvents AddinSettings As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents Box2 As Microsoft.Office.Tools.Ribbon.RibbonBox
  Friend WithEvents btnChangeSettings As Microsoft.Office.Tools.Ribbon.RibbonButton
  Friend WithEvents Step1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents Box1 As Microsoft.Office.Tools.Ribbon.RibbonBox
  Friend WithEvents cboTemplate As Microsoft.Office.Tools.Ribbon.RibbonComboBox
  Friend WithEvents txtNumberOfPages As Microsoft.Office.Tools.Ribbon.RibbonEditBox
  Friend WithEvents chkUrgent As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
  Friend WithEvents Separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
  Friend WithEvents txtLocation As Microsoft.Office.Tools.Ribbon.RibbonEditBox
End Class
