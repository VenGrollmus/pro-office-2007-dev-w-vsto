<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WBExplorer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WBExplorer))
    Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
    Me.btnRefresh = New System.Windows.Forms.Button
    Me.tvWorkbooks = New System.Windows.Forms.TreeView
    Me.SuspendLayout()
    '
    'ImageList
    '
    Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList.Images.SetKeyName(0, "OrganizerHS.png")
    Me.ImageList.Images.SetKeyName(1, "ShowGridlinesHS.png")
    Me.ImageList.Images.SetKeyName(2, "CanvasScaleHS.png")
    Me.ImageList.Images.SetKeyName(3, "List_NumberedHS.png")
    '
    'btnRefresh
    '
    Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top
    Me.btnRefresh.Location = New System.Drawing.Point(0, 0)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(192, 44)
    Me.btnRefresh.TabIndex = 1
    Me.btnRefresh.Text = "&Refresh"
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'tvWorkbooks
    '
    Me.tvWorkbooks.Dock = System.Windows.Forms.DockStyle.Top
    Me.tvWorkbooks.FullRowSelect = True
    Me.tvWorkbooks.ImageIndex = 2
    Me.tvWorkbooks.ImageList = Me.ImageList
    Me.tvWorkbooks.Location = New System.Drawing.Point(0, 44)
    Me.tvWorkbooks.Name = "tvWorkbooks"
    Me.tvWorkbooks.SelectedImageIndex = 0
    Me.tvWorkbooks.Size = New System.Drawing.Size(192, 299)
    Me.tvWorkbooks.TabIndex = 2
    '
    'WBExplorer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.tvWorkbooks)
    Me.Controls.Add(Me.btnRefresh)
    Me.Name = "WBExplorer"
    Me.Size = New System.Drawing.Size(192, 360)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ImageList As System.Windows.Forms.ImageList
  Friend WithEvents btnRefresh As System.Windows.Forms.Button
  Friend WithEvents tvWorkbooks As System.Windows.Forms.TreeView

End Class
