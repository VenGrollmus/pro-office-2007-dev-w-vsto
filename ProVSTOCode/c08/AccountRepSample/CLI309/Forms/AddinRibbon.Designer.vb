Partial Class AddinRibbon
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddinRibbon))
    Me.Tab1 = New Microsoft.Office.Tools.Ribbon.RibbonTab
    Me.Opportunities = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.btnCreateProject = New Microsoft.Office.Tools.Ribbon.RibbonButton
    Me.Separator1 = New Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Me.btnToggleOpps = New Microsoft.Office.Tools.Ribbon.RibbonToggleButton
    Me.Tab1.SuspendLayout()
    Me.Opportunities.SuspendLayout()
    Me.SuspendLayout()
    '
    'Tab1
    '
    Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
    Me.Tab1.ControlId.OfficeId = "TabContact"
    Me.Tab1.Groups.Add(Me.Opportunities)
    Me.Tab1.Label = "TabContact"
    Me.Tab1.Name = "Tab1"
    '
    'Opportunities
    '
    Me.Opportunities.Items.Add(Me.btnCreateProject)
    Me.Opportunities.Items.Add(Me.Separator1)
    Me.Opportunities.Items.Add(Me.btnToggleOpps)
    Me.Opportunities.Label = "Account Actions"
    Me.Opportunities.Name = "Opportunities"
    Me.Opportunities.Position = Microsoft.Office.Tools.Ribbon.RibbonPosition.BeforeOfficeId("GroupShow")
    '
    'btnCreateProject
    '
    Me.btnCreateProject.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
    Me.btnCreateProject.Image = Global.CLI309.My.Resources.Resources.Properties1
    Me.btnCreateProject.Label = "Convert Opp to Project"
    Me.btnCreateProject.Name = "btnCreateProject"
    Me.btnCreateProject.ShowImage = True
    Me.btnCreateProject.SuperTip = "Convert the selected Opportunity into a Project in the Accounting System"
    '
    'Separator1
    '
    Me.Separator1.Name = "Separator1"
    '
    'btnToggleOpps
    '
    Me.btnToggleOpps.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
    Me.btnToggleOpps.Image = CType(resources.GetObject("btnToggleOpps.Image"), System.Drawing.Image)
    Me.btnToggleOpps.Label = "Hide Opportunities"
    Me.btnToggleOpps.Name = "btnToggleOpps"
    Me.btnToggleOpps.ShowImage = True
    Me.btnToggleOpps.SuperTip = "Show/Hide the Opportunities task pane"
    '
    'AddinRibbon
    '
    Me.Name = "AddinRibbon"
    Me.RibbonType = "Microsoft.Outlook.Contact"
    Me.Tabs.Add(Me.Tab1)
    Me.Tab1.ResumeLayout(False)
    Me.Tab1.PerformLayout()
    Me.Opportunities.ResumeLayout(False)
    Me.Opportunities.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
  Friend WithEvents Opportunities As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents btnCreateProject As Microsoft.Office.Tools.Ribbon.RibbonButton
  Friend WithEvents Separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
  Friend WithEvents btnToggleOpps As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
End Class

Partial Class ThisRibbonCollection
    Inherits Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property AddinRibbon() As AddinRibbon
        Get
            Return Me.GetRibbon(Of AddinRibbon)()
        End Get
    End Property
End Class
