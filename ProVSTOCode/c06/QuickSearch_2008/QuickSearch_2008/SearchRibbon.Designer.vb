Partial Class SearchRibbon
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchRibbon))
    Me.Tab1 = New Microsoft.Office.Tools.Ribbon.RibbonTab
    Me.Group1 = New Microsoft.Office.Tools.Ribbon.RibbonGroup
    Me.txtSearchString = New Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Me.btnSearch = New Microsoft.Office.Tools.Ribbon.RibbonButton
    Me.Tab1.SuspendLayout()
    Me.Group1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Tab1
    '
    Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
    Me.Tab1.Groups.Add(Me.Group1)
    Me.Tab1.Label = "Quick Search"
    Me.Tab1.Name = "Tab1"
    '
    'Group1
    '
    Me.Group1.Items.Add(Me.txtSearchString)
    Me.Group1.Items.Add(Me.btnSearch)
    Me.Group1.Label = "Search Criteria"
    Me.Group1.Name = "Group1"
    '
    'txtSearchString
    '
    Me.txtSearchString.Label = "Find"
    Me.txtSearchString.Name = "txtSearchString"
    Me.txtSearchString.SizeString = "1111111111111111111111111"
    '
    'btnSearch
    '
    Me.btnSearch.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
    Me.btnSearch.Label = "Find It!"
    Me.btnSearch.Name = "btnSearch"
    Me.btnSearch.ShowImage = True
    '
    'SearchRibbon
    '
    Me.Name = "SearchRibbon"
    Me.RibbonType = resources.GetString("$this.RibbonType")
    Me.Tabs.Add(Me.Tab1)
    Me.Tab1.ResumeLayout(False)
    Me.Tab1.PerformLayout()
    Me.Group1.ResumeLayout(False)
    Me.Group1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
  Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
  Friend WithEvents txtSearchString As Microsoft.Office.Tools.Ribbon.RibbonEditBox
  Friend WithEvents btnSearch As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection
    Inherits Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property SearchRibbon() As SearchRibbon
        Get
            Return Me.GetRibbon(Of SearchRibbon)()
        End Get
    End Property
End Class
